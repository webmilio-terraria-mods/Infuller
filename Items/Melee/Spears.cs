using static Terraria.ID.ItemID;

namespace Infuller.Items.Melee;

public class Spears : MeleeSystem<ISpear>
{
    protected override void SetupVanilla()
    {
        Add(new(WeaponHands.OneHanded), 
            AdamantiteGlaive, 
            CobaltNaginata,
            MushroomSpear, MythrilHalberd,
            ObsidianSwordfish, OrichalcumHalberd,
            PalladiumPike, 
            Spear, Swordfish,
            TheRottedFork, Trident,
            
            JoustingLance, HallowJoustingLance, ShadowJoustingLance,
            Javelin, DayBreak); // TODO Check if this makes any sense since they do Ranged damage.

        Add(new(WeaponHands.TwoHanded),
            ChlorophytePartisan,
            DarkLance,
            MonkStaffT2,
            Gungnir,
            NorthPole,
            ThunderSpear, TitaniumTrident);
    }
}