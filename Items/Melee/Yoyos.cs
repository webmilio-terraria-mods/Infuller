using static Terraria.ID.ItemID;

namespace Infuller.Items.Melee;

public class Yoyos : MeleeSystem<IYoyo>
{
    protected override void SetupVanilla()
    {
        Add(new(WeaponHands.OneHanded),
            Amarok,
            Cascade, Chik, Code1, Code2, CorruptYoyo, CrimsonYoyo,
            FormatC, 
            Gradient, 
            HelFire, 
            JungleYoyo, 
            Kraken,
            Rally, RedsYoyo,
            Terrarian, TheEyeOfCthulhu,
            ValkyrieYoyo, Valor, 
            WoodYoyo,
            Yelets);
    }
}