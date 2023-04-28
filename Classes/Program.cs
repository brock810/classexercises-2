namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            var vehicle = new car();
            vehicle.Make = "Mustang";
            vehicle.Model = "GT";
            vehicle.Year = 2008;

            Console.WriteLine($"wow that is a nice {vehicle.Make}, its a {vehicle.Model}? is the year of that {vehicle.Year}?");
            
        }
    }
}

