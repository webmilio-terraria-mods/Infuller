using System;
using System.Collections.Generic;
using Infuller.Extensions;
using System.Collections.ObjectModel;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infuller.Items;

public abstract class ItemSystem : ModSystem, IItemSystem
{
    #region Instanciated

    protected abstract void SetupVanilla();
    protected virtual void PostSetupVanilla() { }

    protected abstract void SetupModded();
    protected virtual void PostSetupModded() { }

    public override void OnModLoad()
    {
        SetupVanilla();
        PostSetupVanilla();

        SetupModded();
        PostSetupModded();

        PostSetup();
    }

    protected virtual void PostSetup() { }

    public abstract override void Unload();

    public abstract Type Type { get; protected set; }

    #endregion


    #region Static

    private static Dictionary<int, (List<IItemSystem> original, ReadOnlyCollection<IItemSystem> read)> _systems;
    private static Dictionary<int, (List<Type> original, ReadOnlyCollection<Type> read)> _types;

    internal static void StaticModLoad()
    {
        _systems = new();
        _types = new();
    }

    internal static void StaticModUnload()
    {
        _systems = null;
        _types = null;
    }

    public static void ForModItems<TK>(Action<int, TK> action)
    {
        for (int type = ItemID.Count; type < ItemLoader.ItemCount; type++)
        {
            var item = ItemLoader.GetItem(type);

            if (item is TK t)
                action(type, t);
        }
    }

    internal static void RegisterSystem(int type, IItemSystem system)
    {
        static (List<T> original, ReadOnlyCollection<T> read) CreatePair<T>()
        {
            List<T> list = new();
            return new(list, list.AsReadOnly());
        }

        _systems.AddOrGet(type, out var systems, CreatePair<IItemSystem>);
        _types.AddOrGet(type, out var items, CreatePair<Type>);

        systems.original.Add(system);
        items.original.Add(system.Type);
    }

    public static bool GetSystems(int type, out ReadOnlyCollection<IItemSystem> systems)
    {
        if (!_systems.TryGetValue(type, out var values))
        {
            systems = null;
            return false;
        }

        systems = values.read;
        return true;
    }

    public static bool TryGetItemTypes(int type, out ReadOnlyCollection<Type> types)
    {
        if (!_types.TryGetValue(type, out var values))
        {
            types = null;
            return false;
        }

        types = values.read;
        return true;
    }

    #endregion
}

public abstract class ItemSystem<TI, TR> : ItemSystem
{
    protected abstract override void SetupVanilla();

    protected override void SetupModded()
    {
        ForModItems<TI>(delegate (int type, TI item)
        {
            Register(type, RecordSelector(item));
            SetupModItem(type, item);
        });
    }

    public override void Load()
    {
        Items = new TR[ItemLoader.ItemCount + 1];
    }

    public override void PostSetupContent()
    {
        Mod.Logger.Info($"Registered {Registered} {typeof(TI).Name}/{typeof(TR).Name}.");
    }

    public override void Unload()
    {
        Items = null;
    }

    protected void Add(TR record, params int[] types)
    {
        for (int i = 0; i < types.Length; i++)
        {
            Register(types[i], record);
        }
    }

    public void Register(int type, TR record)
    {
        Items[type] = record;
        Registered++;

        RegisterSystem(type, this);
    }

    protected virtual void SetupModItem(int type, TI item) { }

    public static bool Is(int type) => Items[type] != null;

    public static bool TryGet(int type, out TR record)
    {
        record = Items[type];
        return record != null;
    }

    // ReSharper disable once StaticMemberInGenericType
    protected static TR[] Items { get; private set; }

    protected abstract Func<TI, TR> RecordSelector { get; }
    public int Registered { get; protected set; }

    public override Type Type { get; protected set; } = typeof(TI);
}