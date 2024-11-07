using System;
using System.Reflection;

namespace VehicleInspection
{
    public class Truck : Vehicle 
    {
        // Constructor that takes parameters required by the base Vehicle class
        public Truck(string brand, string model, DateTime productionDate, DateTime lastInspection)
            : base(brand, model, productionDate, lastInspection)
        {
        }

        // Implement the abstract InspectionStatus property
        public override bool InspectionStatus =>
            (DateTime.Now.Year - ProductionDate.Year > 1) && (DateTime.Now.Year - LastInspection.Year > 1);

        // Override DisplayInfo to provide Truck-specific information
        public override string DisplayInfo()
        {
            return $"Truck: {Brand} {Model}";
        }

        // Override SetTireType to set the MaxRimSize based on tire type
        public override void SetTireType(bool isWinterTire)
        {
            MaxRimSize = isWinterTire ? 17 : 20;
        }
    }

  
}


