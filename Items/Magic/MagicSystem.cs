using System;
using Terraria.ModLoader;

namespace Infuller.Items.Magic;

public abstract class MagicSystem<T> : TypeSystem<T, MagicRecord> where T : IMagic
{
    protected override void PostSetupVanilla()
    {
        for (int i = 0; i < Items.Length; i++)
        {
            if (Items[i] != default)
                ModContent.GetInstance<Magics>().TryAdd(i, Items[i]);
        }
    }

    protected override void SetupModded()
    {
        ForModItems<T>(delegate (int type, T item)
        {
            Register(type, item.MagicRecord);
            SetupModItem(type, item);
        });
    }

    protected override Func<T, MagicRecord> RecordSelector { get; } = magic => magic.MagicRecord;
}