using System;
using static Terraria.ID.ItemID;

namespace Infuller.Items.Ranged.Bow;

public class Bows : TypeSystem<IBow, BowRecord>
{
    protected override void SetupVanilla()
    {
        for (var i = 0; i < VanillaIDs.Length; i++)
        {
            Register(VanillaIDs[i], new());
        }
    }

    protected override Func<IBow, BowRecord> RecordSelector { get; } = b => b.BowRecord;

    private int[] VanillaIDs { get; } =
    {
        DD2BetsyBow, BloodRainBow, BorealWoodBow, CopperBow, DaedalusStormbow, DemonBow, EbonwoodBow, FairyQueenRangedItem, GoldBow, HellwingBow, 
        IceBow, IronBow, LeadBow, Marrow, MoltenFury, PalmWoodBow, PearlwoodBow, Phantasm, DD2PhoenixBow, PlatinumBow, PulseBow, 
        RichMahoganyBow, ShadewoodBow, ShadowFlameBow, SilverBow, TendonBow, BeesKnees, TinBow, Tsunami, TungstenBow, WoodenBow
    };
}