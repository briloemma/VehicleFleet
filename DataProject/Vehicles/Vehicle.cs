using DataProject;
using System.Collections.Generic;
using System.Linq;
using System.Xml.Serialization;
using UtilProject.Exceptions;

namespace VehicleFleet
{
    [XmlInclude(typeof(Truck))]
    [XmlInclude(typeof(Bus))]
    [XmlInclude(typeof(Scooter))]
    [XmlInclude(typeof(Car))]
    public class Vehicle
    {
        public Engine engine;
        public Gear gear;
        public Transmission transmission;
        public string id;

        public string Id
        {
            set
            {
                if (ListsOfVehicles.allVehiclesList.Any(vehicle => vehicle.Id == value))
                    throw new AddException($"Can't add a vehicle. A vehicle with this id: {value} already exists");
                else id = value;
            }
            get { return id; }
        }

        public Vehicle(string id, Engine engine, Gear gear, Transmission transmission)
        {
            Id = id;
            this.engine = engine;
            this.gear = gear;
            this.transmission = transmission;
        }
        public Vehicle() { }

        public void ShowVehicleInfo()
        {
            engine.ShowEngineInfo();
            transmission.ShowTransmissionInfo();
            gear.ShowGearInfo();
        }

    }
}
