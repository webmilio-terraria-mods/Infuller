using System.Collections.Generic;
using Terraria.ModLoader;
using static Terraria.ID.ItemID;

namespace Infuller.Items.Guns;

public class Guns : ItemSystem
{
    private static Dictionary<int, GunType> _gunTypes;

    public static bool Is(int type)
    {
        return _gunTypes.ContainsKey(type);
    }

    protected override void SetupVanilla()
    {
        static void Add(GunType type, params int[] types)
        {
            for (int i = 0; i < types.Length; i++)
            {
                Register(types[i], type);
            }
        }
        
        Add(GunType.Pistol, DartPistol, FlintlockPistol, Handgun, OnyxBlaster, PhoenixBlaster, Revolver, TheUndertaker, VenusMagnum);
        Add(GunType.Shotgun, Boomstick, QuadBarrelShotgun, Shotgun, TacticalShotgun, Xenopopper);
        Add(GunType.SMG, Uzi);

        Add(GunType.Flamethrower, EldMelter, Flamethrower);
        Add(GunType.Cannon, SnowballCannon, StarCannon, SuperStarCannon, Sandgun);
        Add(GunType.Other, Blowgun, Blowpipe);
        
        Add(GunType.SemiAutomaticRifle, DartRifle, Musket, RedRyder, SniperRifle);
        Add(GunType.AutomaticRifle, CandyCornRifle, ChainGun, ClockworkAssaultRifle, Gatligator, Megashark, Minishark, SDMG, VortexBeater);
    }

    protected override void SetupModded()
    {
        ForModItems(delegate(int type, IGun gun)
        {
            Register(type, gun.GunType);
        });
    }

    public static void Register(int type, GunType gunType) => _gunTypes.Add(type, gunType);

    public override void PostSetupContent()
    {
        _gunTypes = new();

        SetupVanilla();
        SetupModded();
    }

    public override void Unload()
    {
        _gunTypes = null;
    }

    protected int[] VanillaIDs { get; } =
    {
        Blowgun, Blowpipe, Boomstick, CandyCornRifle, ChainGun, ClockworkAssaultRifle, DartPistol, DartRifle, EldMelter, Flamethrower,
        FlintlockPistol, Gatligator, Handgun, Megashark, Minishark, Musket, OnyxBlaster, PhoenixBlaster, QuadBarrelShotgun, RedRyder,
        Revolver, SDMG, Sandgun, Shotgun, SniperRifle, SnowballCannon, StarCannon, SuperStarCannon, TacticalShotgun, TheUndertaker,
        Uzi, VenusMagnum, VortexBeater, Xenopopper
    };
}