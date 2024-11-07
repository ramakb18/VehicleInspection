using System;
using System.Reflection;

namespace VehicleInspection
{
    public class Car : Vehicle
    {
        public Car(string brand, string model, DateTime productionDate, DateTime lastInspection)
            : base(brand, model, productionDate, lastInspection)
        {
        }

        public override bool InspectionStatus =>
            (DateTime.Now.Year - ProductionDate.Year > 4) && (DateTime.Now.Year - LastInspection.Year > 2);

        public override string DisplayInfo()
        {
            return $"Car: {Brand} {Model}";
        }

        public override void SetTireType(bool isWinterTire)
        {
            MaxRimSize = isWinterTire ? 16 : 22;
        }
    }
}
