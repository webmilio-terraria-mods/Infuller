namespace Infuller;

internal static class Extensions
{
    internal static void Set<T>(this T[] array, T value, params int[] indexes)
    {
        for (int i = 0; i < indexes.Length; i++)
        {
            array[indexes[i]] = value;
        }
    }
}