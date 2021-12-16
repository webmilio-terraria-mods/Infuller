using System;
using Infuller.Items;
using static Terraria.ID.BuffID;

namespace Infuller.Buff;

public class Buffs : TypeSystem<IBuff, BuffRecord>
{
    protected override void SetupVanilla()
    {
        Add(new(DOT: true, Fire: true), 
            Burning,
            CursedInferno,
            Daybreak,
            Frostburn,
            OnFire, OnFire3,
            ShadowFlame);
    }

    protected override Func<IBuff, BuffRecord> RecordSelector { get; } = buff => buff.BuffRecord;
}