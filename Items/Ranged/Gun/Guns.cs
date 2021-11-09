using System.Collections.Generic;
using static Terraria.ID.ItemID;

namespace Infuller.Items.Ranged.Gun;

public class Guns : ItemSystem
{
    protected static Dictionary<int, GunType> items;

    public static bool Is(int type) => items.ContainsKey(type);

    public static bool TryGet(int type, out GunType gunType) => items.TryGetValue(type, out gunType);

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

    public static void Register(int type, GunType gunType) => items.Add(type, gunType);

    public override void PostSetupContent()
    {
        items = new();

        SetupVanilla();
        SetupModded();
    }

    public override void Unload()
    {
        items = null;
    }
}