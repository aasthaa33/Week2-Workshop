using System.Net.Http.Headers;

namespace Task_3;

class Program
{
    static void Main(string[] args)
    {
        byte byteValue = 200;
        short shortValue = 30000;
        int intValue = 42;
        long longValue = 1234592222222222222;
        float floatValue = 3.14f;
        double doubleValue = 3.1415926;
        decimal decimalValue = 3.145763876m;
        char charValue = 'A';
        bool boolValue = true;

        // Converting integer value to string
        string intToString = intValue.ToString();
        
        // Converting string value to double
        double stringTodouble = double.Parse("3.14");

        Console.WriteLine("Byte: " + byteValue);
        Console.WriteLine("Short: " + shortValue);
        Console.WriteLine("Int: " + intValue);
        Console.WriteLine("Long: " + longValue);
        Console.WriteLine("Float: " + floatValue);
        Console.WriteLine("Double: " + doubleValue);
        Console.WriteLine("Decimal: " + decimalValue);
        Console.WriteLine("Char: " + charValue);
        Console.WriteLine("Bool: " + boolValue);
     
        
        Console.WriteLine("Integer to string: " + intToString);
        Console.WriteLine("String to double: " + stringTodouble);
    }
}