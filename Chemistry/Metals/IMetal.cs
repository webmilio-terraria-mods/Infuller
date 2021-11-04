namespace Infuller.Chemistry.Metals;

public interface IMetal
{
    public const float
        CopperPoint = 1_085,
        TinPoint = 231.9f,

        IronPoint = 1_538,
        LeadPoint = 327.5f,
        
        SilverPoint = 961.8f,
        TungstenPoint = 3_422,

        GoldPoint = 1_064,
        PlatinumPoint = 1_768,
        
        MeteoritePoint = 1_482.2f,
        
        DemonitePoint = 1_500f,
        CrimtanePoint = DemonitePoint,
        
        ObsidianPoint = 2_072,
        HellstonePoint = TungstenPoint;

    /// <summary>The melting temperature in celcius.</summary>
    public float MeltingPoint { get; }
}