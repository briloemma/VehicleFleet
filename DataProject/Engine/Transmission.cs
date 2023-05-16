using System;

namespace VehicleFleet
{
    public class Transmission
    {
        public string Type { get; set; }
        public string Manufacturer { get; set; }
        public int NumberOfGears { get; set; }

        public Transmission()
        {

        }

        public Transmission(string type, string manufacturer, int numberOfGears)
        {
            Type = type;
            Manufacturer = manufacturer;
            NumberOfGears = numberOfGears;
        }

        public void ShowTransmissionInfo()
        {
            Console.WriteLine($"Transmission Info: transmission type - {Type}; " +
                $"manufacturer - {Manufacturer};" +
                $" number of gears - {NumberOfGears}");
        }
    }
}
