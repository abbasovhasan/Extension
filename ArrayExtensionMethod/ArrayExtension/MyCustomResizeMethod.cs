using System;
namespace ArrayExtensionMethod.ArrayExtension;

public static class MyCustomResizeMethod
{
    public static void ResizeAndAdd<T>(this T[] array, T[] newElements)
    {
        int originalLength = array.Length;

        int newLength = originalLength + newElements.Length;

        Array.Resize(ref array, newLength);

        for (int i = 0; i < newLength; i++)
        {
            array[originalLength + i] = newElements[i];
        }
    }
}
