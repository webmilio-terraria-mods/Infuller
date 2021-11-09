using System.Collections.Generic;
using Terraria.ModLoader;

namespace Infuller.Items.Magic;

public abstract class MagicSystem<T> : ItemSystem where T : IMagic
{
    protected static Dictionary<int, MagicRecord> items;

    public static bool Is(int type) => items.ContainsKey(type);

    public static bool TryGet(int type, out MagicRecord record) => items.TryGetValue(type, out record);

    protected override void SetupModded()
    {
        ForModItems<T>(delegate (int type, T item)
        {
            Register(type, item.MagicRecord);
            SetupModItem(type, item);
        });
    }

    protected virtual void SetupModItem(int type, T item) { }
    
    protected static void Add(MagicRecord record, params int[] types)
    {
        for (int i = 0; i < types.Length; i++)
        {
            Register(types[i], record);
        }
    }

    public static void Register(int type, MagicRecord record)
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