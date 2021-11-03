using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.PrefixID;

namespace Infuller.Prefix;

public class PrefixAlignments : ModSystem
{
    private static Dictionary<int, PrefixAlignment> _vanilla;

    public static bool TryGet(int prefix, out PrefixAlignment alignment)
    {
        alignment = PrefixAlignment.Neutral;

        if (prefix is > 0 and < PrefixID.Count)
        {
            alignment = _vanilla[prefix];
            return true;
        }

        // ReSharper disable once SuspiciousTypeConversion.Global

        if (PrefixLoader.GetPrefix(prefix) is not IInfullerPrefix ip)
            return false;

        alignment = ip.Alignment;
        return true;
    }

    public override void Load()
    {
        _vanilla = new();

        void AddAlignment(PrefixAlignment alignment, params int[] prefixes)
        {
            for (int i = 0; i < prefixes.Length; i++)
                _vanilla.Add(prefixes[i], alignment);
        }

        AddAlignment(PrefixAlignment.VeryBad, Broken, Terrible, Annoying, Awful, Awkward, Ignorant, Unhappy, Lethargic, Shoddy);
        AddAlignment(PrefixAlignment.Bad, Shameful, Sluggish, Weak, Deranged, Tiny, Dull, Damaged, Slow, Small, Inept, Lazy);
        AddAlignment(PrefixAlignment.Neutral, Intense, Frenzying);
        AddAlignment(PrefixAlignment.Good, Heavy, Light, Powerful, Keen, Nimble, Furious, Nasty, Ruthless, Zealous, Bulky, Taboo, Manic, Pointy, Quick,
            Hurtful, Large, Dangerous, Sighted, Agile, Sharp, Adept, Forceful, Strong);
        AddAlignment(PrefixAlignment.VeryGood, Murderous, Massive, Celestial, Intimidating, Unpleasant, Deadly, Demonic, Superior, Rapid, Hasty,
            Staunch, Mystic, Deadly2, Savage, Masterful, Godly, Legendary, Legendary2, Unreal, Mythical);
    }

    public override void Unload()
    {
        _vanilla = null;
    }
}