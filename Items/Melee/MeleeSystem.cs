using System;
using Terraria.ModLoader;

namespace Infuller.Items.Melee;

public abstract class MeleeSystem<TI> : TypeSystem<TI, MeleeRecord> where TI : IMelee
{
    protected override void SetupModItem(int type, TI item) { }

    protected override Func<TI, MeleeRecord> RecordSelector { get; } = item => item.MeleeRecord;
}