using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Vehicle_Catalogue
{
    class Program
    {

        class Vehicle
        {
            public string Type { get; set; }
            public string Model { get; set; }
            public string Color { get; set; }
            public int Horsepower { get; set; }
        }

        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, Vehicle> vehicles = new Dictionary<string, Vehicle>();
            double carsAverageHorsePower = 0.0, cars = 0.0;
            double truckAverageHorsePower = 0.0, trucks = 0.0;

            while (input != "End")
            {

                List<string> vehicleProp = input.ToLower().Split(' ').ToList();

                switch (vehicleProp[0])
                {
                    case "car": carsAverageHorsePower += double.Parse(vehicleProp[3]); cars++; break;
                    case "truck": truckAverageHorsePower += double.Parse(vehicleProp[3]); trucks++; break;
                }

                String type = vehicleProp[0].Substring(0, 1).ToUpper() + vehicleProp[0].Substring(1);
                String model = vehicleProp[1].Substring(0, 1).ToUpper() + vehicleProp[1].Substring(1);

                Vehicle vehicle = new Vehicle
                {
                    Type = type,
                    Model = model,
                    Color = vehicleProp[2],
                    Horsepower = int.Parse(vehicleProp[3])
                };

                vehicles[model] = vehicle;

                input = Console.ReadLine();
            }

            carsAverageHorsePower /= cars;
            truckAverageHorsePower /= trucks;

            string output = Console.ReadLine();

            while (output != "Close the Catalogue")
            {
                Console.WriteLine($"Type: {vehicles[output].Type}");
                Console.WriteLine($"Model: {vehicles[output].Model}");
                Console.WriteLine($"Color: {vehicles[output].Color}");
                Console.WriteLine($"Horsepower: {vehicles[output].Horsepower}");
                output = Console.ReadLine();
            }

            if (carsAverageHorsePower > 0)
            {
                Console.WriteLine($"Cars have average horsepower of: {carsAverageHorsePower:F2}.");
            }
            else
            {
                Console.WriteLine($"Cars have average horsepower of: {0:F2}.");
            }

            if (truckAverageHorsePower > 0)
            {
                Console.WriteLine($"Trucks have average horsepower of: {truckAverageHorsePower:F2}.");
            }
            else
            {
                Console.WriteLine($"Trucks have average horsepower of: {0:F2}.");
            }
        }
    }
}
