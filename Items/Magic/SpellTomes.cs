using static Terraria.ID.ItemID;

namespace Infuller.Items.Magic;

public class SpellTomes : MagicSystem<ISpellTome>
{
    protected override void SetupVanilla()
    {
        Add(new(IMagic.ElementArcane), BookofSkulls, DemonScythe, LunarFlareBook, MagnetSphere);
        Add(new(IMagic.ElementWater), GoldenShower, RazorbladeTyphoon, WaterBolt);

        Add(new(IMagic.ElementArcane, IMagic.ElementFire), CursedFlame);
        Add(new(IMagic.ElementArcane, IMagic.ElementNature), CrystalStorm);
    }
}