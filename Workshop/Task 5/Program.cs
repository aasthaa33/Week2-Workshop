namespace Task_5;

class Program
{
    static void Main(string[] args)
    {
        // DateTime variable representing birthdate
        DateTime birthDate = new DateTime(2005, 12, 05);
        
        // Variable representing current date
        DateTime currentDate = DateTime.Now;

        // Calculating age using Timespan
        TimeSpan ageDifference = currentDate - birthDate;
        
        Console.WriteLine("Birthdate: "+ birthDate);
        Console.WriteLine("CurrentDate:  "+ currentDate);

        // Calculating age in years
        int age = (int)ageDifference.TotalDays / 365;
        Console.WriteLine("Age: "+ age);
        
        // Adding 10 days to birthdate
        DateTime date = birthDate.AddDays(10);
        Console.WriteLine("Birthdate after adding 10 days : "+ date);



    }
}