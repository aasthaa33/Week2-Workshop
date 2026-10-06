namespace NewProject1;

class Circle
{
    private const double PI = 3.14;

    public double CalculateArea(double radius)
    {
        return PI * radius * radius;
    }
    static void Main(string[] args)
    {
        Circle circle = new Circle();
       Console.WriteLine("Area:" + circle.CalculateArea(5));
    }
}