using System.Collections.Generic;
using VehicleFleet;

namespace DataProject
{
    public static class ListsOfVehicles
    {
        public static List<Vehicle> allVehiclesList = new List<Vehicle>();

        static ListsOfVehicles()
        {
            allVehiclesList = AllVehicles();
        }

        private static List<Car> cars = new List<Car>()
        {
            new Car ("C1","TeslaX","Silver","50000 USD",
                new Engine (670,0, "electric motor", "ST-484"),
                new Gear (4, 74884, 400),
                new Transmission("Single-speed transaxle", "Tesla", 8)),
            new Car ("C2","TeslaX","Black Onix","55000 USD",
                new Engine(670,0, "electric motor", "ST-48954"),
                new Gear(4, 7584, 410),
                new Transmission("electronically controlled automatic transmission", "Tesla", 8))
        };

        private static List<Bus> buses = new List<Bus>()
        {
            new Bus ("B1","School Bus", "Yellow", 47,
                new Engine(470,30, "diesel engine", "GT90453"),
                new Gear(6, 373737, 4700),
                new Transmission("Single-speed transaxle", "King Long", 5)),
            new Bus ("B2","Intercity Bus", "White", 47,
                new Engine(400,25, "diesel engine", "GT90453"),
                new Gear(6, 5757383, 4000),
                new Transmission("electronically controlled automatic transmission", "King Long", 5))
        };

        private static List<Scooter> scooters = new List<Scooter>()
        {
            new Scooter ("S1","Red", "Italy",
                new Engine(3,1, "diesel engine","SC377"),
                new Gear(2, 388393, 50),
                new Transmission("Single-speed transaxle", "Aeon", 0)),
            new Scooter ("S2","White", "France",
                new Engine(3,1, "diesel engine","SC378"),
                new Gear(2, 474747, 50),
                new Transmission("electronically controlled automatic transmission", "Aeon", 0))
        };

        private static List<Truck> trucks = new List<Truck>()
        {
            new Truck ("T1",1200, "White", "Chemical products transportation",
                new Engine(560,40,"hybrid engine", "EN-362"),
                new Gear(18, 373782, 6000),
                new Transmission("splitterTransmission", "Caterpillar", 10)),
            new Truck ("T2",1400, "Black", "Wood transportation",
                new Engine(640,50,"hybrid engine", "EN-36448"),
                new Gear(18, 373782, 7000),
                new Transmission("splitterTransmission", "Caterpillar", 12))
        };

        private static List<Vehicle> AllVehicles()
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            vehicles.AddRange(cars);
            vehicles.AddRange(scooters);
            vehicles.AddRange(trucks);
            vehicles.AddRange(buses);
            return vehicles;
        }
    }
}
