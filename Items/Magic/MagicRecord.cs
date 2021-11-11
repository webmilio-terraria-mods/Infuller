using System;

namespace Infuller.Items.Magic;

public record MagicRecord(MagicEffectType EffectType, params string[] Elements)
{
    public bool IsElement(string element)
    {
        for (int i = 0; i < Elements.Length; i++)
        {
            if (Elements[i].Equals(element, StringComparison.OrdinalIgnoreCase))
                return true;
        }

        return false;
    }
}