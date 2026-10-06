namespace Array;

class Program
{

    static void Main(string[] args)
    {
        int[] numbers = [11, 6, 2, 8, 4];
        System.Array.Sort(numbers);
        
        Console.WriteLine("Sorted array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        System.Array.Reverse(numbers);
        Console.WriteLine("Reversed array:");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        int index = System.Array.IndexOf(numbers, 6);
        Console.WriteLine("Index of 6:" + index);

    }
}