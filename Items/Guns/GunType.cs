using System;

namespace Infuller.Items.Guns;

[Flags]
public enum GunType : ushort
{
    Pistol = 0b0001,
    Shotgun = 0b0010,
    SMG = 0b0100,

    Cannon = 0b1000,
    Flamethrower = 0b0001_0000,

    Rifle = 0b0010_0000,
    SemiAutomaticRifle = 0b0100_0000 | Rifle,
    AutomaticRifle = 0b1000_0000 | Rifle,

    Other = 0b0001_0000_0000
}