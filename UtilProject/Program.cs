using DataProject;
using System.Collections.Generic;
using VehicleFleet;

namespace UtilProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var vehicle = Util.GetAutoByParameter("BusColor", "Yellow");

            List<Vehicle> list2 = Util.RemoveAuto("C1");

            Car car = new Car("C3", "TeslaX", "Silver", "50000 USD",
             new Engine(640, 0, "electric motor", "ST-484"),
             new Gear(4, 748383, 400),
             new Transmission("Single-speed transaxle", "Tesla", 8));

            Car car1 = new Car("C4", "Silver", "50000 USD",
             new Engine(640, 0, "electric motor", "ST-484"),
             new Gear(4, 748383, 400),
             new Transmission("Single-speed transaxle", "Tesla", 8));

            Car car2 = new Car("C1", "Silver", "50000 USD",
            new Engine(640, 0, "electric motor", "ST-484"),
            new Gear(4, 748383, 400),
            new Transmission("Single-speed transaxle", "Tesla", 8));

            List<Vehicle> list1 = Util.UpdateAuto("C1", car);

            var carModell = Util.AddCarModel(car1, "New Car Model");

            List<Vehicle> list3 = ListsOfVehicles.allVehiclesList;
           
            list3.Add(car2);
            

        }
    }
}
