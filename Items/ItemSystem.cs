using System;
using Terraria.ID;
using Terraria.ModLoader;

namespace Infuller.Items;

public abstract class ItemSystem : ModSystem, IItemSystem
{
    protected abstract void SetupVanilla();
    protected abstract void SetupModded();

    public override void PostSetupContent()
    {
        Items = new bool[ItemLoader.ItemCount + 1]; // Item 0 doesn't exist.

        SetupVanilla();
        SetupModded();
    }

    public override void Unload()
    {
        Items = null;
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

    // ReSharper disable once StaticMemberInGenericType
    protected static bool[] Items { get; private set; }
}

public abstract class ItemSystem<T> : ItemSystem, IItemSystem
{
    protected override void SetupVanilla()
    {
        Items.Set(true, VanillaIDs);
    }

    protected override void SetupModded()
    {
        ForModItems<T>(delegate(int type, T item)
        {
            Register(type);
            SetupModItem(type, item);
        });
    }

    public static void Register(int type) => Items[type] = true;

    protected virtual void SetupModItem(int type, T item) { }

    public static bool Is(int type) => Items[type];

    protected virtual int[] VanillaIDs => throw new NotImplementedException();
}