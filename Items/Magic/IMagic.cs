namespace Infuller.Items.Magic;

public interface IMagic
{
    public const string
        ElementFire = "fire",
        ElementWater = "water",
        // ElementLightning = "lightning",
        ElementNature = "nature",
        ElementArcane = "arcane";

    public MagicRecord MagicRecord { get; }
}