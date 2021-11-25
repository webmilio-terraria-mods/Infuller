using Infuller.Items;
using Terraria.ModLoader;

namespace Infuller;

public class Infuller : Mod
{
    public override void Load()
    {
        ItemSystem.StaticModLoad();
    }

    public override void Unload()
    {
        ItemSystem.StaticModUnload();
    }
}