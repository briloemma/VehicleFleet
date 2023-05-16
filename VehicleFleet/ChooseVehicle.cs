using System;

namespace VehicleFleet
{
    internal class ChooseVehicle
    {
        public static void ChooseYourVehicle()
        {
            Console.WriteLine("Choose your vehicle:" + "\n" + "1 - Car" + "\n" + "2 - Scooter" + "\n" + "3 - Bus" + "\n" + "4- Truck");
            int vehicleOption = int.Parse(Console.ReadLine());
            switch (vehicleOption)
            {
                case 1:
                    Car teslaCar = new Car("CarId 1", "TeslaX", "Silver", "50000 USD",
                        new Engine(670, 0, "electric motor", "ST-484"),
                        new Gear(4, 74884, 400),
                        new Transmission("Single-speed transaxle", "Tesla", 8));
                    teslaCar.ShowCarInfo();
                    break;
                case 2:
                    Scooter scooter = new Scooter("ScooterId 1", "Red", "Italy",
                        new Engine(3, 1, "diesel engine", "SC377"),
                        new Gear(2, 388393, 50),
                        new Transmission("automatic transmission", "Aeon", 0));
                    scooter.ShowScooterInfo();
                    break;
                case 3:
                    Bus bus = new Bus("BusId 1", "School bus", "Yellow", 47,
                       new Engine(470, 30, "diesel engine", "GT90453"),
                       new Gear(6, 373737, 4700),
                       new Transmission("electronically controlled automatic transmission", "King Long", 5));
                    bus.ShowBusInfo();
                    break;
                case 4:
                    Truck truck = new Truck("TruckId 1", 1000, "Black", "Chemical products transportation",
                        new Engine(560, 40, "hybrid engine", "EN-362"),
                        new Gear(18, 373782, 6000),
                        new Transmission("splitterTransmission", "Caterpillar", 10));
                    truck.ShowTruckInfo();
                    break;
            }
        }
    }
}
