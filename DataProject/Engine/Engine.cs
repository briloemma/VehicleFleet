using System;

namespace VehicleFleet
{
    public class Engine
    {
        public int HorsePower { get; set; }
        public double Volume { get; set; }
        public string EngineType { get; set; }
        public string SerialNumber { get; set; }

        public Engine(int horsePower, double volume, string type, string serialNumber)
        {
            HorsePower = horsePower;
            Volume = volume;
            EngineType = type;
            SerialNumber = serialNumber;

        }

        public void ShowEngineInfo()
        {
            Console.WriteLine($"Engine Info: horse power - {HorsePower}; " +
                $"volume - {Volume};" +
                $" type - {EngineType}," +
                $" serial number - {SerialNumber}");
        }
    }
}
