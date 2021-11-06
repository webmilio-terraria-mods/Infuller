using static Terraria.ID.ItemID;

namespace Infuller.Items.Guns;

public class Guns : ItemSystem<IGun>
{
    protected override int[] VanillaIDs { get; } =
    {
        Blowgun, Blowpipe, Boomstick, CandyCornRifle, ChainGun, ClockworkAssaultRifle, DartPistol, DartRifle, EldMelter, Flamethrower,
        FlintlockPistol, Gatligator, Handgun, Megashark, Minishark, Musket, OnyxBlaster, PhoenixBlaster, QuadBarrelShotgun, RedRyder,
        Revolver, SDMG, Sandgun, Shotgun, SniperRifle, SnowballCannon, StarCannon, SuperStarCannon, TacticalShotgun, TheUndertaker,
        Uzi, VenusMagnum, VortexBeater, Xenopopper
    };
}