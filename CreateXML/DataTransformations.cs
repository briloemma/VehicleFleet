using DataProject;
using System.Collections.Generic;
using System.Linq;
using System.Xml;
using System.Xml.Linq;
using VehicleFleet;

namespace CreateXML
{
    public static class DataTransformations
    {
        public static List<T> GetVihecleByType<T>()
        {
            return ListsOfVehicles.allVehiclesList.OfType<T>().ToList();
        }

        public static List<T> GetVihecleByType<T>(IEnumerable<Vehicle> list)
        {
            return list.OfType<T>().ToList();
        }

        public static List<Vehicle> SelectVehiclesWithVolume()
        {
            var allVehicles = ListsOfVehicles.allVehiclesList;
            var selectedVehiclesWithVolume = allVehicles.Where(x => x.engine.Volume >= 1.5);

            return selectedVehiclesWithVolume.ToList();
        }

        public static List<Vehicle> GroupVehiclesByTransmission()

        {
            var allVehicles = ListsOfVehicles.allVehiclesList;
            allVehicles.Sort();

            return allVehicles;
        }

        public static void CreateXMLFile()
        {
            XDocument doc = new XDocument(new XElement("ArrayOfBusesAndTrucks"));
            doc.Save("D:\\document.xml");
        }

        public static void ConvertBusesAndTrucksToXML()
        {
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("D:\\document.xml");
            XmlElement? xRoot = xDoc.DocumentElement;

            var allBuses = GetVihecleByType<Bus>();
            var allTrucks = GetVihecleByType<Truck>();

            foreach (Bus bus in allBuses)
            {
                XmlElement busElem = xDoc.CreateElement("bus");

                XmlElement horsePowerElem = xDoc.CreateElement("horsePower");
                XmlElement volumeElem = xDoc.CreateElement("volume");
                XmlElement serialNumberElem = xDoc.CreateElement("serialNumber");

                XmlText horsePowerText = xDoc.CreateTextNode(bus.engine.HorsePower.ToString());
                XmlText volumeText = xDoc.CreateTextNode(bus.engine.Volume.ToString());
                XmlText serialNumberText = xDoc.CreateTextNode(bus.engine.SerialNumber.ToString());

                horsePowerElem.AppendChild(horsePowerText);
                volumeElem.AppendChild(volumeText);
                serialNumberElem.AppendChild(serialNumberText);

                busElem.AppendChild(volumeElem);
                busElem.AppendChild(serialNumberElem);
                busElem.AppendChild(horsePowerElem);

                xRoot?.AppendChild(busElem);
            }
            foreach (Truck truck in allTrucks)
            {
                XmlElement truckElem = xDoc.CreateElement("truck");

                XmlElement horsePowerElem = xDoc.CreateElement("horsePower");
                XmlElement volumeElem = xDoc.CreateElement("volume");
                XmlElement serialNumberElem = xDoc.CreateElement("serialNumber");

                XmlText horsePowerText = xDoc.CreateTextNode(truck.engine.HorsePower.ToString());
                XmlText volumeText = xDoc.CreateTextNode(truck.engine.Volume.ToString());
                XmlText serialNumberText = xDoc.CreateTextNode(truck.engine.SerialNumber.ToString());

                horsePowerElem.AppendChild(horsePowerText);
                volumeElem.AppendChild(volumeText);
                serialNumberElem.AppendChild(serialNumberText);

                truckElem.AppendChild(volumeElem);
                truckElem.AppendChild(serialNumberElem);
                truckElem.AppendChild(horsePowerElem);

                xRoot?.AppendChild(truckElem);
            }
            xDoc.Save("D:\\document.xml");
        }

    }
}







