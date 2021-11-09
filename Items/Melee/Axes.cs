using static Terraria.ID.ItemID;

namespace Infuller.Items.Melee;

public class Axes : MeleeSystem<IAxe>
{
    protected override void SetupVanilla()
    {
        Add(new(WeaponHands.OneHanded), ShroomiteDiggingClaw);

        Add(new(WeaponHands.TwoHanded),
            AdamantiteWaraxe, 
            BloodLustCluster, BloodHamaxe,
            ChlorophyteGreataxe, CobaltWaraxe, CopperAxe,
            GoldAxe,
            IronAxe,
            LeadAxe, LunarHamaxeNebula, LunarHamaxeSolar, LunarHamaxeStardust, LunarHamaxeVortex,
            MeteorHamaxe, MoltenHamaxe, MythrilWaraxe,
            OrichalcumWaraxe, 
            PalladiumWaraxe, PickaxeAxe, Picksaw, PlatinumAxe,
            SilverAxe, SpectreHamaxe,
            TheAxe, TinAxe, TitaniumWaraxe, TungstenAxe,
            WarAxeoftheNight);
    }
}