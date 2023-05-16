using System;

namespace VehicleFleet
{
    [Serializable]
    public class Bus : Vehicle
    {
        public string BusType { get; set; }
        public string BusColor { get; set; }
        public int MaxCapacity { get; set; }

        public Bus()
        {

        }

        public Bus(string id, string busType, string busColor, int maxCapacity,
           Engine engine, Gear gear, Transmission transmission) :
           base(id, engine, gear, transmission)
        {
            BusType = busType;
            BusColor = busColor;
            MaxCapacity = maxCapacity;
        }
        public void ShowBusInfo()
        {
            ShowVehicleInfo();
            Console.WriteLine($"Bus Info: type - {BusType}; " +
                $"color - {BusColor}; capacity - {MaxCapacity}");
        }
    }
}
