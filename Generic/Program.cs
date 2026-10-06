namespace Generic;

class Program
{
    static void Main(string[] args)
    {
        List<string> fruits = new() {"apple", "banana", "orange"};
        fruits.Add("Strawberry");
        fruits.Remove("apple");

        foreach (string fruit in fruits)
        {
            Console.WriteLine(fruit);
        }
        
        Dictionary<int, string> fruits2 = new Dictionary<int, string>
        {
            {1, "apple"},
            {2, "orange"},
            {3, "banana"},
        };
        
        fruits2.Add(4, "strawberry");
        
        Console.WriteLine("\nDictionary");
        foreach (KeyValuePair<int, string> fruit in fruits2)
        {
            Console.WriteLine("ID: " + fruit.Key +", Fruit: " + fruit.Value);
        }
    }
}