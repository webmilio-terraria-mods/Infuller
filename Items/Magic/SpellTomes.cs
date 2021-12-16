using static Terraria.ID.ItemID;

namespace Infuller.Items.Magic;

public class SpellTomes : MagicSystem<ISpellTome>
{
    protected override void SetupVanilla()
    {
        Add(new(MagicEffectType.Attack, IMagic.ElementArcane), BookofSkulls, DemonScythe, LunarFlareBook, MagnetSphere);

        Add(new(MagicEffectType.Attack, IMagic.ElementWater), RazorbladeTyphoon, WaterBolt);
        Add(new(MagicEffectType.Debuff), GoldenShower);

        Add(new(MagicEffectType.Attack | MagicEffectType.Debuff, IMagic.ElementArcane, IMagic.ElementFire), CursedFlames);
        Add(new(MagicEffectType.Attack, IMagic.ElementArcane, IMagic.ElementNature), CrystalStorm);
    }
}