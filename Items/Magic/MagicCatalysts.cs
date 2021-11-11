using static Terraria.ID.ItemID;

namespace Infuller.Items.Magic;

public class MagicCatalysts : MagicSystem<IMagicCatalyst>
{
    protected override void SetupVanilla()
    {
        Add(new(MagicEffectType.Attack, IMagic.ElementArcane),
            FairyQueenMagicItem,
            LastPrism,
            MagicalHarp, MagicDagger, MedusaHead, 
            NebulaArcanum, NebulaBlaze);

        Add(new(MagicEffectType.Attack, IMagic.ElementArcane, IMagic.ElementFire), SpiritFlame);
        Add(new(MagicEffectType.Attack | MagicEffectType.Debuff, IMagic.ElementArcane, IMagic.ElementFire), ShadowFlameHexDoll);

        Add(new(MagicEffectType.Attack, IMagic.ElementNature), ToxicFlask);

        Add(new(MagicEffectType.Attack, IMagic.ElementArcane, IMagic.ElementNature), 
            SharpTears, SparkleGuitar);
    }
}