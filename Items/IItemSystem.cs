using System;

namespace Infuller.Items;

public interface IItemSystem
{
    public void OnModLoad();
    public void Unload();

    /// <summary>This method always returns false. Only used to guide the signature of future methods.</summary>
    /// <param name="type"></param>
    /// <returns></returns>
    public static bool Is(int type) => false;

    public Type Type { get; }
}