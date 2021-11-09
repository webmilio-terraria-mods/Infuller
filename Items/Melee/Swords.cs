using static Terraria.ID.ItemID;

namespace Infuller.Items.Melee;

public class Swords : MeleeSystem<ISword>
{
    protected override void SetupVanilla()
    {
        Add(new(WeaponHands.OneHanded), AntlionClaw, BeamSword, BeeKeeper, BoneSword, DD2SquireDemonSword, BreathingReed, ChlorophyteSaber, CobaltSword, 
            Cutlass, EnchantedSword, Excalibur, DyeTradersScimitar, FalconBlade, Frostbrand, Gladius, IceBlade, Katana, Keybrand, LightsBane, Muramasa, 
            OrichalcumSword, PsychoKnife, Ruler, Seedler, StarWrath, Starfury, TaxCollectorsStickOfDoom, TitaniumSword, TrueExcalibur,

            Arkhalis, Terragrim,

            CopperShortsword, TinShortsword, IronShortsword, LeadShortsword, SilverShortsword, TungstenShortsword, GoldShortsword, PlatinumShortsword,
            CopperBroadsword, TinBroadsword, IronBroadsword, LeadBroadsword, SilverBroadsword, TungstenBroadsword, GoldBroadsword, PlatinumBroadsword, 
            BorealWoodSword, CactusSword, EbonwoodSword, PalmWoodSword, PearlwoodSword, RichMahoganySword, ShadewoodSword, WoodenSword);

        // Bladed Glove, Clubberfish, Death Sickle, Fetid, Ice Sickle, Slap Hand, Tragic Umbrella, Umbrella, Zombie Arm
        Add(new(WeaponHands.DualWield), StylistKilLaKillScissorsIWish);

        Add(new(WeaponHands.TwoHanded), AdamantiteSword, BladeofGrass, Bladetongue, BloodButcherer, BreakerBlade, CandyCaneSword, ChlorophyteClaymore, ChristmasTreeSword,
            DD2SquireBetsySword, FieryGreatsword, InfluxWaver, Meowmere, MythrilSword, NightsEdge, PalladiumSword, TheHorsemansBlade, TrueNightsEdge,

            BluePhaseblade, BluePhasesaber, GreenPhaseblade, GreenPhasesaber, OrangePhaseblade, OrangePhasesaber, PurplePhaseblade, 
            PurplePhasesaber, RedPhaseblade, RedPhasesaber, WhitePhaseblade, WhitePhasesaber, YellowPhaseblade, YellowPhasesaber);

        Add(new(WeaponHands.OneHanded | WeaponHands.TwoHanded), TerraBlade, Zenith);
    }
}