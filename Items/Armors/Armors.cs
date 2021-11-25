using System;
using static Terraria.ID.ItemID;

namespace Infuller.Items.Armors;

public class Armors : ItemSystem<IArmor, ArmorRecord>
{
    protected override void SetupVanilla()
    {
        Add(new(ArmorType.Heavy),
            AdamantiteHeadgear, AdamantiteHelmet, AdamantiteMask, AdamantiteBreastplate, AdamantiteLeggings,
            AncientArmorHat, AncientArmorShirt, AncientArmorPants, // Forbidden
            AncientHallowedHeadgear, AncientHallowedHelmet, AncientHallowedMask, AncientHallowedHood, AncientHallowedPlateMail, AncientHallowedGreaves,

            BeetleHelmet, BeetleScaleMail, BeetleShell, BeetleLeggings,

            CrimsonHelmet, CrimsonScalemail, CrimsonGreaves,

            FrostHelmet, FrostBreastplate, FrostLeggings,

            GoldHelmet, AncientGoldHelmet, GoldChainmail, GoldGreaves,

            HallowedHeadgear, HallowedHelmet, HallowedMask, HallowedHood, HallowedPlateMail, HallowedGreaves,
            
            LeadHelmet, LeadChainmail, LeadGreaves,

            MeteorHelmet, MeteorSuit, MeteorLeggings,
            MoltenHelmet, MoltenBreastplate, MoltenGreaves,

            OrichalcumHeadgear, OrichalcumHelmet, OrichalcumMask, OrichalcumBreastplate, OrichalcumLeggings,

            PalladiumHeadgear, PalladiumHelmet, PalladiumMask, PalladiumBreastplate, PalladiumLeggings,
            PlatinumHelmet, PlatinumChainmail, PlatinumGreaves,

            SolarFlareHelmet, SolarFlareBreastplate, SolarFlareLeggings,
            SquireGreatHelm, SquirePlating, SquireGreaves,
            SquireAltHead, SquireAltShirt, SquireAltPants, // Valhala
            StardustHelmet, StardustBreastplate, StardustLeggings,

            TinHelmet, TinChainmail, TinGreaves,
            TungstenHelmet, TungstenChainmail, TungstenGreaves,
            TurtleHelmet, TurtleScaleMail, TurtleLeggings,

            // Wood & Derivatives
            BorealWoodHelmet, BorealWoodBreastplate, BorealWoodGreaves,
            EbonwoodHelmet, EbonwoodBreastplate, EbonwoodGreaves,
            PumpkinHelmet, PumpkinBreastplate, PumpkinLeggings
        );

        Add(new(ArmorType.Light),
            BeeHeadgear, BeeBreastplate, BeeGreaves,

            ChlorophyteHeadgear, ChlorophyteHelmet, ChlorophyteMask, ChlorophytePlateMail, ChlorophyteGreaves, 
            CobaltHelmet, CobaltHat, CobaltMask, CobaltBreastplate, CobaltLeggings,
            CopperHelmet, CopperChainmail, CopperGreaves,
            CrystalNinjaHelmet, CrystalNinjaChestplate, CrystalNinjaLeggings, // Crystal Assassin

            IronHelmet, AncientIronHelmet, IronChainmail, IronGreaves,

            FossilHelm, FossilShirt, FossilPants,

            MonkAltHead, MonkAltShirt, MonkAltPants, // Shino Infiltrator,
            MythrilHelmet, MythrilHat, MythrilHood, MythrilChainmail, MythrilGreaves,

            NebulaHelmet, NebulaBreastplate, NebulaLeggings,
            NecroHelmet, NecroBreastplate, NecroGreaves,
            NinjaHood, NinjaShirt, NinjaPants,

            TitaniumHeadgear, TitaniumHelmet, TitaniumMask, TitaniumBreastplate, TitaniumLeggings,

            SilverHelmet, SilverChainmail, SilverGreaves,
            ShroomiteHeadgear, ShroomiteHelmet, ShroomiteMask, ShroomiteBreastplate, ShroomiteLeggings,
            SpookyHelmet, SpookyBreastplate, SpookyLeggings,
            
            VortexHelmet, VortexBreastplate, VortexLeggings,

            // Wood & Derivatives
            CactusHelmet, CactusBreastplate, CactusLeggings,
            PalmWoodHelmet, PalmWoodBreastplate, PalmWoodGreaves,
            PearlwoodHelmet, PearlwoodBreastplate, PearlwoodGreaves
        );

        Add(new ArmorRecord(ArmorType.RobeClothes),
            AnglerHat, AnglerVest, AnglerPants,
            ApprenticeHat, ApprenticeRobe, ApprenticeTrousers,
            ApprenticeAltHead, ApprenticeAltShirt, ApprenticeAltPants, // Dark Artist

            EskimoHood, EskimoCoat, EskimoPants,

            HuntressAltHead, HuntressAltShirt, HuntressAltPants, // Red Riding

            JungleHat, JungleShirt, JunglePants,

            MiningHelmet, MiningShirt, MiningPants,
            
            PinkEskimoHood, PinkEskimoCoat, PinkEskimoPants,
            
            RainHat, RainCoat,

            SpectreHood, SpectreMask, SpectreRobe, SpectrePants,
            SpiderMask, SpiderBreastplate, SpiderGreaves,

            TikiMask, TikiShirt, TikiPants, 

            AmberRobe, AmethystRobe, DiamondRobe, EmeraldStaff, GypsyRobe, RubyRobe, SapphireRobe, TopazRobe
            // Gypsy is Mystic Robe
        );
    }

    protected override Func<IArmor, ArmorRecord> RecordSelector { get; } = armor => armor.ArmorRecord;
}