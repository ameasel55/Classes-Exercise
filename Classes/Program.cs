namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            // dot.notation
            Car myCar = new Car();
            myCar.Make = "Chevrolet";
            myCar.Model = "Geo Metro";
            myCar.Year = 1989;

            Console.WriteLine($"Make of the car: {myCar.Make}");
            Console.WriteLine($"Model of the car: {myCar.Model}");
            Console.WriteLine($"Year of the car: {myCar.Year}");

            // object initializer
            var mazda = new Car()
            {
                Make = "Ford",
                Model = "Pinto",
                Year = 1973
            };
            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();

            Console.WriteLine($"Make of the car: {mazda.Make}");
            Console.WriteLine($"Model of the car: {mazda.Model}");
            Console.WriteLine($"Year of the car: {mazda.Year}");

            // custom
            var pontiac = new Car("Pontiac", "Aztek", 2001);

            Console.WriteLine();
            Console.WriteLine("~~~~~~~~~~~~~~~~~~~~~");
            Console.WriteLine();

            Console.WriteLine($"Make of the car: {pontiac.Make}");
            Console.WriteLine($"Model of the car: {pontiac.Model}");
            Console.WriteLine($"Year of the car: {pontiac.Year}");

            var carList = new List<Car>();
        }
    }
}
