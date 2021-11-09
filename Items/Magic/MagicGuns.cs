using static Terraria.ID.ItemID;

namespace Infuller.Items.Magic;

public class MagicGuns : MagicSystem<IMagicGun>
{
    protected override void SetupVanilla()
    {
        Add(new(IMagic.ElementArcane), 
            BubbleGun, 
            ChargedBlasterCannon, 
            LaserMachinegun, LaserRifle, 
            SpaceGun, 
            RainbowGun, 
            ZapinatorGray, ZapinatorOrange);

        Add(new(IMagic.ElementFire), HeatRay);
        Add(new(IMagic.ElementNature), LeafBlower, WaspGun);
        Add(new(IMagic.ElementWater), BubbleGun);
    }
}