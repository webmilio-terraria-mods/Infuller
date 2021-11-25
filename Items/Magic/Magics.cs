using System;

namespace Infuller.Items.Magic;

public class Magics : ItemSystem<IMagic, MagicRecord>
{
    protected override void SetupVanilla() { }

    public bool TryAdd(int type, MagicRecord record)
    {
        if (TryGet(type, out _))
            return false;

        Register(type, record);
        return true;
    }

    protected override Func<IMagic, MagicRecord> RecordSelector { get; } = magic => magic.MagicRecord;
}