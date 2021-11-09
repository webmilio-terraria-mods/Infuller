using System.Collections.Generic;
using Terraria.ModLoader;

namespace Infuller.Items.Melee;

public abstract class MeleeSystem<T> : ItemSystem where T : IMelee
{
    protected static Dictionary<int, WeaponHands> items;

    public static bool Is(int type) => items.ContainsKey(type);

    public static bool TryGet(int type, out WeaponHands hands) => items.TryGetValue(type, out hands);

    protected override void SetupModded()
    {
        ForModItems<T>(delegate (int type, T item)
        {
            Register(type, item.WeaponHands);
            SetupModItem(type, item);
        });
    }

    protected virtual void SetupModItem(int type, T item) { }

    protected static void Add(WeaponHands hands, params int[] types)
    {
        for (int i = 0; i < types.Length; i++)
        {
            Register(types[i], hands);
        }
    }

    public static void Register(int type, WeaponHands hands)
    {
        items.Add(type, hands);
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