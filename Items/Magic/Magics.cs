using System.Collections.Generic;

namespace Infuller.Items.Magic;

public class Magics : MagicSystem<IMagic>
{
    protected override void SetupVanilla()
    {
        items = new Dictionary<int, MagicRecord>();
    }
}