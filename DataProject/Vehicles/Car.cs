using System;

namespace VehicleFleet
{
    [Serializable]
    public class Car : Vehicle
    {
        public string CarModel { get; set; }
        public string CarColor { get; set; }
        public string CarPrice { get; set; }

        public Car()
        {

        }

        public Car(string id, string carModel, string carColor, string carPrice,
           Engine engine, Gear gear, Transmission transmission) :
           base(id, engine, gear, transmission)
        {
            CarModel = carModel;
            CarColor = carColor;
            CarPrice = carPrice;
        }
        public Car(string id, string carColor, string carPrice,
          Engine engine, Gear gear, Transmission transmission) :
          base(id, engine, gear, transmission)
        {
            CarColor = carColor;
            CarPrice = carPrice;
        }

        public void ShowCarInfo()
        {
            ShowVehicleInfo();
            Console.WriteLine($"Car Info: model - {CarModel}; " +
                $"color - {CarColor}; price - {CarPrice}");
        }

    }
}
