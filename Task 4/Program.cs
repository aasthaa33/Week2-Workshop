namespace Task_4;

class Program
{
    static void Main(string[] args)
    {
        // single-dimesional integer array
        int[] numbers = { 11, 2, 4, 6, 8 };
        
        // Sorting array in ascending order
        Array.Sort(numbers);
        Console.WriteLine("Sorted Array:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }
        
        // Reversing the sorted array
        Array.Reverse(numbers);
        
        Console.WriteLine("\nReverse Array:");

        // Printing each element of the array using a for loop
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        // Finding the position of 2 using Array.IndexOf()
        int index = Array.IndexOf(numbers, 2);
        Console.WriteLine("Index of 2 is: "+ index);
    }
}