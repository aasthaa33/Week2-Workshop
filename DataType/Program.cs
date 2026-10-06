namespace NewProject2;

class Data
{
    static void Main(string[] args)
    {
        byte byteValue = 200;
        int intValue = 42;
        short shortValue = 30000;
        long longValue = 100000000;
        float floatValue = 3.14f;
        double doubleValue = 3.14159;
        decimal decimalValue = 99.99m;
        char charValue = 'A';
        bool boolValue = true;
        
        string intToString = intValue.ToString();
        double stringToDouble = double.Parse("3.14");
        
        Console.WriteLine("byte:" + byteValue);
        Console.WriteLine("intValue:" + intValue);
        Console.WriteLine("shortValue:" + shortValue);
        Console.WriteLine("longValue:" + longValue);
        Console.WriteLine("floatValue:" + floatValue);
        Console.WriteLine("doubleValue:" + doubleValue);
        Console.WriteLine("decimalValue:" + decimalValue);
        Console.WriteLine("charValue:" + charValue);
        Console.WriteLine("boolValue:" + boolValue);
        
        Console.WriteLine("intToString:" + intToString);
        Console.WriteLine("stringToDouble:" + stringToDouble);
    }
}




