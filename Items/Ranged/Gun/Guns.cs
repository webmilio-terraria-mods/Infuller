using System;
using System.Collections.Generic;
using static Terraria.ID.ItemID;

namespace Infuller.Items.Ranged.Gun;

public class Guns : ItemSystem<IGun, GunRecord>
{
    protected override void SetupVanilla()
    {
        Add(new(GunClass.Pistol), DartPistol, FlintlockPistol, Handgun, OnyxBlaster, PhoenixBlaster, Revolver, TheUndertaker, VenusMagnum);
        Add(new(GunClass.Shotgun), Boomstick, QuadBarrelShotgun, Shotgun, TacticalShotgun, Xenopopper);
        Add(new(GunClass.SMG), Uzi);

        Add(new(GunClass.Flamethrower), EldMelter, Flamethrower);
        Add(new(GunClass.Cannon), SnowballCannon, StarCannon, SuperStarCannon, Sandgun);
        Add(new(GunClass.Other), Blowgun, Blowpipe);
        
        Add(new(GunClass.SemiAutomaticRifle), DartRifle);
        Add(new GunRecord(GunClass.BoltAction), Musket, RedRyder, SniperRifle);

        Add(new(GunClass.AutomaticRifle), 
            BubbleGun,
            CandyCornRifle, ChainGun, ClockworkAssaultRifle, 
            LaserRifle,
            Gatligator, 
            Megashark, Minishark, 
            SpaceGun, SDMG, 
            VortexBeater);
    }

    protected override Func<IGun, GunRecord> RecordSelector { get; } = g => g.GunRecord;
}