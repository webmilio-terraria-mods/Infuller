using System;
using static Terraria.ID.ItemID;

namespace Infuller.Items.Ranged.Repeater;

public class Repeaters : TypeSystem<IRepeater, RangedRecord>
{
    protected override void SetupVanilla()
    {
        for (var i = 0; i < VanillaIDs.Length; i++)
        {
            Register(VanillaIDs[i], new());
        }
    }

    private int[] VanillaIDs { get; } =
    {
        AdamantiteRepeater, ChlorophyteShotbow, CobaltRepeater, HallowedRepeater, MythrilRepeater, OrichalcumRepeater, PalladiumRepeater,
        StakeLauncher, TitaniumRepeater
    };

    protected override Func<IRepeater, RangedRecord> RecordSelector { get; } = r => r.RangedRecord;
}