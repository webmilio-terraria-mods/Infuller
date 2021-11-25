using System;

namespace Infuller.Items.Armors;

[Flags]
public enum ArmorType
{
    Heavy = 0b0000_0001,

    Light = 0b0001_0000,
    RobeClothes = Light | 0b0010_0000
}