using System;

namespace VehicleFleet
{
    [Serializable]
    public class Truck : Vehicle
    {
        public int TruckWeight { get; set; }
        public string TruckColor { get; set; }
        public string TruckType { get; set; }


        public Truck()
        {

        }

        public Truck(string id, int truckWeight, string truckColor, string truckType,
            Engine engine, Gear gear, Transmission transmission) :
            base(id, engine, gear, transmission)
        {
            TruckWeight = truckWeight;
            TruckColor = truckColor;
        }

        public void ShowTruckInfo()
        {
            ShowVehicleInfo();
            Console.WriteLine($"Truck Info: weight - {TruckWeight}; " +
                $"color - {TruckColor}; " +
                $"type - {TruckType}");
        }
    }
}
