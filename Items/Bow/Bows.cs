using static Terraria.ID.ItemID;

namespace Infuller.Items.Bow;

public class Bows : ItemSystem<IBow>
{
    protected override int[] VanillaIDs { get; } =
    {
        DD2BetsyBow, BloodRainBow, BorealWoodBow, CopperBow, DaedalusStormbow, DemonBow, EbonwoodBow, 4953, GoldBow, HellwingBow, 
        IceBow, IronBow, LeadBow, Marrow, MoltenFury, PalmWoodBow, PearlwoodBow, Phantasm, DD2PhoenixBow, PlatinumBow, PulseBow, 
        RichMahoganyBow, ShadewoodBow, ShadowFlameBow, SilverBow, TendonBow, BeesKnees, TinBow, Tsunami, TungstenBow, WoodenBow
    };
}