using static Terraria.ID.ItemID;

namespace Infuller.Items.Melee;

public class Flails : MeleeSystem<IFlail>
{
    protected override void SetupVanilla()
    {
        Add(new(WeaponHands.OneHanded),
            ChainGuillotines,
            ChainKnife,
            Flairon);

        Add(new(WeaponHands.TwoHanded), 
            Anchor,
            BallOHurt, BlueMoon,
            DaoofPow, DripplerFlail, 
            FlamingMace, FlowerPow,
            GolemFist,
            KOCannon,
            Mace, 
            Sunfury,
            TheMeatball);
    }
}