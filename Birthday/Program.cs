namespace Birthday;

class Program
{
    static void Main(string[] args)
    {
        DateTime birthDate = new DateTime(2005, 12, 5);
        DateTime currentDate = DateTime.Now;
        
        TimeSpan ageDifference = currentDate - birthDate;

        int age = (int)(ageDifference.TotalDays / 365.25);

        Console.WriteLine("Birthdate: " + birthDate);
        Console.WriteLine(currentDate);
        Console.WriteLine("Age: " + age + " years old");

        DateTime newDate = birthDate.AddDays(10);
        Console.WriteLine("Birthdate + 10 days: " + newDate);
    }
}