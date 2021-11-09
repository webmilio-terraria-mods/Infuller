using System;

namespace Infuller.Items;

[Flags]
public enum WeaponHands : byte
{
    OneHanded = 1,
    DualWield = OneHanded << 1 | OneHanded,
    TwoHanded = OneHanded << 2
}