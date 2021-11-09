using System.Collections.Generic;
using Terraria.ModLoader;

namespace Infuller.Items.Melee;

public abstract class MeleeSystem<T> : ItemSystem where T : IMelee
{
    protected static Dictionary<int, MeleeRecord> items;

    public static bool Is(int type) => items.ContainsKey(type);

    public static bool TryGet(int type, out MeleeRecord hands) => items.TryGetValue(type, out hands);

    protected override void SetupModded()
    {
        ForModItems<T>(delegate (int type, T item)
        {
            Register(type, item.MeleeRecord);
            SetupModItem(type, item);
        });
    }

    protected virtual void SetupModItem(int type, T item) { }

    protected static void Add(MeleeRecord record, params int[] types)
    {
        for (int i = 0; i < types.Length; i++)
        {
            Register(types[i], record);
        }
    }

    public static void Register(int type, MeleeRecord record)
    {
        items.Add(type, record);
    }

    public override void PostSetupContent()
    {
        items = new(ItemLoader.ItemCount + 1);

        base.PostSetupContent();
        Mod.Logger.Info($"Registered {items.Count} {typeof(T).Name}.");
    }

    public override void Unload()
    {
        items = null;
    }
}