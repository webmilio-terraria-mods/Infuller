using static Terraria.ID.ItemID;

namespace Infuller.Items.Magic;

public class MagicGuns : MagicSystem<IMagicGun>
{
    protected override void SetupVanilla()
    {
        Add(new(MagicEffectType.Attack, IMagic.ElementArcane),
            ChargedBlasterCannon, 
            LaserMachinegun, LaserRifle, 
            SpaceGun, 
            RainbowGun, 
            ZapinatorGray, ZapinatorOrange);

        Add(new(MagicEffectType.Attack, IMagic.ElementFire), HeatRay);
        Add(new(MagicEffectType.Attack, IMagic.ElementNature), LeafBlower, WaspGun);
        Add(new(MagicEffectType.Attack, IMagic.ElementWater), BubbleGun);
    }
}