using System;

namespace Infuller.Items.Guns;

[Flags]
public enum GunType : byte
{
    Pistol = 0b0000_0001,
    Shotgun = 0b0000_0010,
    SMG = 0b0000_0100,

    Flamethrower = 0b0001_0000,
    Cannon = 0b0000_1000,

    Rifle = 0b0010_0000,
    SemiAutomaticRifle = Rifle | 0b0001,
    AutomaticRifle = Rifle | 0b0010,

    Other = 0b1000_0000
}