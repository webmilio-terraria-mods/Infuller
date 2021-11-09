using static Terraria.ID.ItemID;

namespace Infuller.Items.Melee;

public class Flails : MeleeSystem<IFlail>
{
    protected override void SetupVanilla()
    {
        Add(new(WeaponHands.TwoHanded), 
            BallOHurt, BlueMoon,
            DaoofPow, DripplerFlail, 
            FlamingMace, FlowerPow,
            Mace, 
            Sunfury,
            TheMeatball);
    }
}