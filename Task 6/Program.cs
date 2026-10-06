namespace Task_6;

class Program
{
    static void Main(string[] args)
    {
        // creating a list
        List<string> fruits = new() {"orange", "banana", "strawberry"};
       
        //adding new fruit to the list
        fruits.Add("apple");

        // removing one fruit from the list
        fruits.Remove("banana");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
       
        Dictionary<int, string> fruits2 = new Dictionary<int, string>
        {
            { 1, "apple" },
            { 2, "orange" },
            { 3, "banana" }
        };

        // Add a new entry
        fruits2.Add(4, "strawberry");

        // Print all key-value pairs
        Console.WriteLine("\nFruit Dictionary:");

        foreach (KeyValuePair<int, string> fruit in fruits2)
        {
            Console.WriteLine("ID: " + fruit.Key + ", Fruit: " + fruit.Value);
        }
    }
}