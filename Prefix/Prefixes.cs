using System.Collections.Generic;
using Terraria.ID;
using Terraria.ModLoader;
using static Terraria.ID.PrefixID;

namespace Infuller.Prefix;

public class Prefixes : ModSystem
{
    private static Dictionary<int, PrefixAlignment> _alignments;

    public static bool TryGet(int prefix, out PrefixAlignment alignment)
    {
        return _alignments.TryGetValue(prefix, out alignment);
    }

    public override void Load()
    {
        _alignments = new();

        static void AddAlignment(PrefixAlignment alignment, params int[] prefixes)
        {
            for (int i = 0; i < prefixes.Length; i++)
                Register(prefixes[i], alignment);
        }

        AddAlignment(PrefixAlignment.VeryBad, Broken, Terrible, Annoying, Awful, Awkward, Ignorant, Unhappy, Lethargic, Shoddy);
        AddAlignment(PrefixAlignment.Bad, Shameful, Sluggish, Weak, Deranged, Tiny, Dull, Damaged, Slow, Small, Inept, Lazy);
        AddAlignment(PrefixAlignment.Neutral, Intense, Frenzying);
        AddAlignment(PrefixAlignment.Good, Heavy, Light, Powerful, Keen, Nimble, Furious, Nasty, Ruthless, Zealous, Bulky, Taboo, Manic, Pointy, Quick,
            Hurtful, Large, Dangerous, Sighted, Agile, Sharp, Adept, Forceful, Strong);
        AddAlignment(PrefixAlignment.VeryGood, Murderous, Massive, Celestial, Intimidating, Unpleasant, Deadly, Demonic, Superior, Rapid, Hasty,
            Staunch, Mystic, Deadly2, Savage, Masterful, Godly, Legendary, Legendary2, Unreal, Mythical);
    }

    public static void Register(int type, PrefixAlignment alignment) => _alignments.Add(type, alignment);

    public override void PostSetupContent()
    {
        for (int i = PrefixID.Count; i < PrefixLoader.PrefixCount; i++)
        {
            var prefix = PrefixLoader.GetPrefix(i);

            // ReSharper disable once SuspiciousTypeConversion.Global
            if (prefix is IPrefix ip)
                _alignments.Add(i, ip.Alignment);
        }
    }

    public override void Unload()
    {
        _alignments = null;
    }
}