using static Terraria.ID.ItemID;

namespace Infuller.Items.Ranged.Repeater;

public class Repeaters : ItemSystem<IRepeater>
{
    protected override int[] VanillaIDs { get; } =
    {
        AdamantiteRepeater, ChlorophyteShotbow, CobaltRepeater, HallowedRepeater, MythrilRepeater, OrichalcumRepeater, PalladiumRepeater,
        StakeLauncher, TitaniumRepeater
    };
}