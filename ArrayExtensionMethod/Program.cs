using System;

public static class ArrayExtensions
{
    public static T[] ResizeAndAdd<T>(this T[] array, params T[] newElements)
    {
        if (array == null)
        {
            throw new ArgumentNullException(nameof(array), "Array cannot be null");
        }

        if (newElements == null || newElements.Length == 0)
        {
            return array; 
        }

        int originalLength = array.Length;
        int newLength = originalLength + newElements.Length;

        Array.Resize(ref array, newLength);

        for (int i = 0; i < newElements.Length; i++)
        {
            array[originalLength + i] = newElements[i];
        }

        return array;
    }
}

internal class Program
{
    static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3 };

        // Extension method çağrısı ile diziye elemanlar ekleniyor
        numbers = numbers.ResizeAndAdd(4, 5);

        // Sonucu ekrana yazdırma
        Console.WriteLine(string.Join(", ", numbers)); // Output: 1, 2, 3, 4, 5
    }

}
