using Terraria.ID;
using Terraria.ModLoader;

namespace Infuller.Items;

public abstract class ItemSystem<T> : ModSystem
{
    protected static bool[] items;

    protected void SetupVanilla()
    {
        items.Set(true, VanillaIDs);
    }

    protected virtual void SetupModded()
    {
        for (int i = ItemID.Count; i < items.Length; i++)
        {
            var item = ItemLoader.GetItem(i);

            // ReSharper disable once SuspiciousTypeConversion.Global
            if (item is T)
                items[i] = true;
        }
    }

    public static bool Is(int type) => items[type];

    public override void PostSetupContent()
    {
        items = new bool[ItemLoader.ItemCount + 1]; // Item 0 doesn't exist.

        SetupVanilla();
        SetupModded();
    }

    public override void Unload()
    {
        items = null;
    }

    protected abstract int[] VanillaIDs { get; }
}