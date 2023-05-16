namespace CreateXML
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //SerializeUtil.Serialize("selectedVehicles.xml", DataTransformations.SelectVehiclesWithVolume());
            SerializeUtil.Serialize("vehiclesGroupedByTransmission.xml", DataTransformations.GroupVehiclesByTransmission());
            //DataTransformations.CreateXMLFile();
            //DataTransformations.ConvertBusesAndTrucksToXML();
        }
    }
}
