using static Terraria.ID.ItemID;

namespace Infuller.Items.Magic;

// Also emcompasses staffs.
public class Wands : MagicSystem<IWand>
{
    protected override void SetupVanilla()
    {
        Add(new(IMagic.ElementArcane),
            MagicMissile,
            PrincessWeapon,
            RainbowRod,
            ShadowbeamStaff, SkyFracture, SoulDrain, SpectreStaff,
            ThunderStaff,
            UnholyTrident,

            AmberStaff, AmethystStaff, DiamondStaff, EmeraldStaff, RubyStaff, SapphireStaff, TopazStaff);

        Add(new(IMagic.ElementFire),
            ApprenticeStaffT3,
            ClingerStaff,
            Flamelash, FlowerofFire,
            InfernoFork,
            WandofSparking);

        Add(new(IMagic.ElementNature),
            BatScepter, BookStaff,
            CrimsonRod,
            NettleBurst, PoisonStaff,
            Razorpine,
            StaffofEarth, StaffofRegrowth, ScourgeoftheCorruptor,
            VenomStaff, Vilethorn);

        Add(new(IMagic.ElementWater), 
            AquaScepter, 
            BlizzardStaff, 
            FlowerofFrost, FrostStaff,
            IceRod);

        Add(new(IMagic.ElementFire, IMagic.ElementNature), MeteorStaff, MonkStaffT1);
        Add(new(IMagic.ElementArcane, IMagic.ElementNature), CrystalSerpent, CrystalVileShard, MonkStaffT3, NimbusRod);
    }
}