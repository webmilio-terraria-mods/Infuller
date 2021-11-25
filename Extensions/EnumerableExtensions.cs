using System;
using System.Collections.Generic;

namespace Infuller.Extensions;

internal static class EnumerableExtensions
{
    public static TValue AddOrGet<TKey, TValue, T>(this IDictionary<TKey, TValue> dictionary, TKey key, TValue newValue, out TValue value)
    {
        if (dictionary.TryGetValue(key, out value))
            return value;

        dictionary.Add(key, value = newValue);
        return value;
    }

    public static TValue AddOrGet<TKey, TValue>(this IDictionary<TKey, TValue> dictionary, TKey key, out TValue value, Func<TValue> provider)
    {
        if (dictionary.TryGetValue(key, out value))
            return value;

        dictionary.Add(key, value = provider());
        return value;
    }

    internal static void Set<T>(this T[] array, T value, params int[] indexes)
    {
        for (int i = 0; i < indexes.Length; i++)
        {
            array[indexes[i]] = value;
        }
    }
}