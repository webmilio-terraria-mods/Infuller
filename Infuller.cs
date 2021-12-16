using Infuller.Items;
using Terraria.ModLoader;

namespace Infuller;

public class Infuller : Mod
{
    public override void Load()
    {
        TypeSystem.StaticModLoad();
    }

    public override void Unload()
    {
        TypeSystem.StaticModUnload();
    }
}