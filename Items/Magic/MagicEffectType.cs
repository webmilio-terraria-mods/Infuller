using System;

namespace Infuller.Items.Magic;

[Flags]
public enum MagicEffectType
{
    Attack = 1 << 1,
    Defense = Attack << 1,
    Status = Defense << 1,

    Buff = Status << 1 | Status,
    Debuff = Buff << 1 | Status
}