namespace Task_2;

class Circle
{
    const double PI = 3.14;
    
    public double calculateArea (double radius)
    {
        return PI * radius * radius;
    }

    public double calculatePerimeter(double radius)
    {
        return 2 * PI * radius;
    }
    static void Main(string[] args)
    {
        // PI = 3.24;  Error cause PI is declare as a  constant so it cannot be reassigned again. It is immutable.

        Circle circle = new Circle();
        Console.WriteLine("Area of circle: " + circle.calculateArea(PI));
        Console.WriteLine("Perimeter of circle: " + circle.calculatePerimeter(PI));



    }
}