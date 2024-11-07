using System;

namespace VehicleInspection
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                // Car instance with all required parameters
                Vehicle car = new Car("Audi", "A6", new DateTime(2018, 7, 1), new DateTime(2022, 12, 8));
                car.SetTireType(true);  // Setting to winter tire
                Console.WriteLine(car.DisplayInfo());
                Console.WriteLine($"Inspection needed for car: {car.InspectionStatus}");
                Console.WriteLine($"Car Max Rim Size: {car.MaxRimSize}");
                Console.WriteLine($"Interface Info: {car.GetInterfaceInfo()}");
                Console.WriteLine();

                // Truck instance with all required parameters
                Vehicle truck = new Truck("Volvo", "H6", new DateTime(2018, 10, 1), new DateTime(2021, 10, 1));
                truck.SetTireType(false);  // Setting to summer tire
                Console.WriteLine(truck.DisplayInfo());
                Console.WriteLine($"Inspection needed for truck: {truck.InspectionStatus}");
                Console.WriteLine($"Truck Max Rim Size: {truck.MaxRimSize}");
                Console.WriteLine($"Interface Info: {truck.GetInterfaceInfo()}");
            }
        }
    }

}


