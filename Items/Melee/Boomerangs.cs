using static Terraria.ID.ItemID;

namespace Infuller.Items.Melee;

public class Boomerangs : MeleeSystem<IBoomerang>
{
    protected override void SetupVanilla()
    {
        Add(new(WeaponHands.OneHanded),
            Bananarang, BloodyMachete, 
            CombatWrench,
            EnchantedBoomerang,
            Flamarang, FlyingKnife, FruitcakeChakram,
            IceBoomerang,
            LightDisc,
            PaladinsHammer, PossessedHatchet,
            BouncingShield, 
            Shroomerang,
            ThornChakram, 
            WoodenBoomerang);
    }
}