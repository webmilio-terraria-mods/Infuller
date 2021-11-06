using Terraria.ModLoader;
using static Terraria.ID.ItemID;
using ItemID = Terraria.ID.ItemID;

namespace Infuller.Items.Bow;

public class Bows : ModSystem
{
    private static bool[] _bows;

    public override void PostSetupContent()
    {
        _bows = new bool[ItemLoader.ItemCount + 1]; // Item 0 doesn't exist.

        SetupVanilla();
        SetupModded();
    }

    private static void SetupVanilla()
    {
        _bows.Set(true, 
            DD2BetsyBow, BloodRainBow, BorealWoodBow, CopperBow, DaedalusStormbow, DemonBow, EbonwoodBow,
            4953, GoldBow, HellwingBow, IceBow, IronBow, LeadBow, Marrow, MoltenFury, PalmWoodBow, PearlwoodBow,
            Phantasm, DD2PhoenixBow, PlatinumBow, PulseBow, RichMahoganyBow, ShadewoodBow, ShadowFlameBow, SilverBow, 
            TendonBow, BeesKnees, TinBow, Tsunami, TungstenBow, WoodenBow);
    }

    private static void SetupModded()
    {
        for (int i = ItemID.Count; i < _bows.Length; i++)
        {
            var item = ItemLoader.GetItem(i);

            // ReSharper disable once SuspiciousTypeConversion.Global
            if (item is IBow)
                _bows[i] = true;
        }
    }

    public override void Unload()
    {
        _bows = null;
    }
}