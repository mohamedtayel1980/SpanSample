using System;

class Program
{
    static void Main(string[] args)
    {
        // Create an array of integers
        int[] numbers = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

        // Create a Span from the array
        Span<int> numbersSpan = numbers;

        // Slice the span to get a range from the 3rd to the 7th element (inclusive)
        Span<int> slicedSpan = numbersSpan.Slice(start: 2, length: 6);

        // Modify elements in the sliced span
        for (int i = 0; i < slicedSpan.Length; i++)
        {
            slicedSpan[i] += 10;
        }

        // Display the original array to see the changes
        Console.WriteLine("Modified Array:");
        foreach (var number in numbers)
        {
            Console.WriteLine(number);
        }

        // Example of accessing individual elements
        Console.WriteLine("\nAccessing individual elements:");
        Console.WriteLine("First element of slicedSpan: " + slicedSpan[0]);
        Console.WriteLine("Second element of slicedSpan: " + slicedSpan[1]);
    }
}
