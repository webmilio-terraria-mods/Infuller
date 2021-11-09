using static Terraria.ID.ItemID;

namespace Infuller.Items.Magic;

public class MagicCatalysts : MagicSystem<IMagicCatalyst>
{
    protected override void SetupVanilla()
    {
        Add(new(IMagic.ElementArcane),
            FairyQueenMagicItem,
            MagicalHarp, MagicDagger, MedusaHead, 
            NebulaArcanum, NebulaBlaze);
        Add(new(IMagic.ElementArcane, IMagic.ElementFire), ShadowFlameHexDoll, SpiritFlame);

        Add(new(IMagic.ElementNature), ToxicFlask);
        Add(new(IMagic.ElementArcane, IMagic.ElementNature), FairyQueenRangedItem, SharpTears, SparkleGuitar);
    }
}