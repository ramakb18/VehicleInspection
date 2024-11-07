using System;
using static VehicleInspection.IWheels;

namespace VehicleInspection
{
    public abstract class Vehicle : IWheels
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public DateTime ProductionDate { get; set; }
        public DateTime LastInspection { get; set; }

        public int MaxRimSize { get; set; }

        protected Vehicle(string brand, string model, DateTime productionDate, DateTime lastInspection)
        {
            Brand = brand;
            Model = model;
            ProductionDate = productionDate;
            LastInspection = lastInspection;
        }

        // Abstract properties and methods 
        public abstract bool InspectionStatus { get; }

        public abstract void SetTireType(bool isWinterTire);

        public virtual string DisplayInfo()
        {
            return $"Brand: {Brand}, Model: {Model}, Production Date: {ProductionDate.ToShortDateString()}";
        }

        public string GetInterfaceInfo() => ((IWheels)this).Info();
    }
}

