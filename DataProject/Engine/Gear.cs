using System;

namespace VehicleFleet
{
    public class Gear
    {
        public int NumberOfWheels { get; set; }
        public int Number { get; set; }
        public int LoadCapacity { get; set; }

        public Gear(int numberOfWheels, int number, int loadCapacity)
        {
            NumberOfWheels = numberOfWheels;
            Number = number;
            LoadCapacity = loadCapacity;
        }

        public void ShowGearInfo()
        {
            Console.WriteLine($"Gear Info: number of wheels - {NumberOfWheels}; " +
                $"number - {Number}, " +
                $"load capacity - {LoadCapacity}");
        }
    }
}
