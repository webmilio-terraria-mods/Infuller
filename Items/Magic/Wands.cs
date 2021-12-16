using static Terraria.ID.ItemID;

namespace Infuller.Items.Magic;

// Also emcompasses staffs.
public class Wands : MagicSystem<IWand>
{
    protected override void SetupVanilla()
    {
        Add(new(MagicEffectType.Attack | MagicEffectType.Buff, IMagic.ElementArcane),
            SoulDrain);

        Add(new(MagicEffectType.Attack, IMagic.ElementArcane),
            MagicMissile,
            PrincessWeapon,
            RainbowRod,
            ShadowbeamStaff, SkyFracture, SpectreStaff,
            ThunderStaff,
            UnholyTrident,

            AmberStaff, AmethystStaff, DiamondStaff, EmeraldStaff, RubyStaff, SapphireStaff, TopazStaff);

        Add(new(MagicEffectType.Attack | MagicEffectType.Debuff, IMagic.ElementFire),
            ApprenticeStaffT3,
            ClingerStaff,
            Flamelash, FlowerofFire,
            InfernoFork, 
            WandofSparking);

        Add(new(MagicEffectType.Attack, IMagic.ElementNature),
            BatScepter, BookStaff,
            NettleBurst,
            Razorpine,
            StaffofEarth, StaffofRegrowth, ScourgeoftheCorruptor,
            Vilethorn);

        Add(new(MagicEffectType.Attack | MagicEffectType.Debuff, IMagic.ElementNature),
            PoisonStaff, VenomStaff);

        Add(new(MagicEffectType.Attack, IMagic.ElementWater), 
            AquaScepter, 
            BlizzardStaff,
            CrimsonRod,
            FrostStaff,
            IceRod,
            NimbusRod);

        Add(new(MagicEffectType.Attack | MagicEffectType.Debuff, IMagic.ElementWater), FlowerofFrost);

        Add(new(MagicEffectType.Attack, IMagic.ElementFire, IMagic.ElementNature), MeteorStaff, MonkStaffT1);
        Add(new(MagicEffectType.Attack, IMagic.ElementArcane, IMagic.ElementNature), CrystalSerpent, CrystalVileShard, MonkStaffT3);
    }
}