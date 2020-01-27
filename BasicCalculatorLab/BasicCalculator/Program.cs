using System;

namespace BasicCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("*** BASIC CALCULATOR ***");

            Console.WriteLine("Enter Current Temperature in Fahrenheit");

            // int.Parse will take a string data type and convert it to an int data type
            int Current = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter Relative Humidity");
            int secondNumber = int.Parse(Console.ReadLine());

            int sum = Current - (9*(100 - secondNumber) / 25);
            Console.WriteLine("The Dew Point is " + sum);

            Console.WriteLine("Enter Wind Speed");
            int windSpeed = int.Parse(Console.ReadLine());

            double windChill = 35.74
            + (0.6125 * Current)
           - 35.74 * Math.Pow(windSpeed, 0.16)
           + 0.4275 * Current * Math.Pow(windSpeed, 0.16);

            Console.WriteLine("The wind chill is" + windChill);

       
        }

        
    }
}
