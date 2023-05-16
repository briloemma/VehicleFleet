using System;

namespace VehicleFleet
{
    [Serializable]
    public class Scooter : Vehicle
    {
        public string ScooterColor { get; set; }
        public string ScooterCountryOfOrigin { get; set; }

        public Scooter()
        {

        }

        public Scooter(string id, string scooterColor, string scooterCountryOfOrigin,
            Engine engine, Gear gear, Transmission transmission) :
            base(id, engine, gear, transmission)
        {
            ScooterColor = scooterColor;
            ScooterCountryOfOrigin = scooterCountryOfOrigin;
        }

        public void ShowScooterInfo()
        {
            ShowVehicleInfo();
            Console.WriteLine($"Scooter Info: color - {ScooterColor}; " +
                $"country of origin - {ScooterCountryOfOrigin}");
        }
    }
}
