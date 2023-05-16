using DataProject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using UtilProject.Exceptions;
using VehicleFleet;

namespace UtilProject
{
    public static class Util
    {
        public static Vehicle GetAutoByParameter(string parameter, string value)
        {
            foreach (var vehicle in ListsOfVehicles.allVehiclesList)
            {
                Type myType = vehicle.GetType();

                PropertyInfo[] myProperty = myType.GetProperties();

                foreach (PropertyInfo prop in myProperty)
                {
                    bool param = prop.ToString().Contains(parameter);
                    bool? val = prop.GetValue(vehicle)?.ToString().Contains(value);
                    if (param && val == true)
                    {
                        Console.WriteLine($"Type: {vehicle.GetType()}, id: {vehicle.Id}");
                        return vehicle;
                    }
                }
            }
            throw new GetAutoByParameterException($"Couldn't find a vechile with {parameter} parameter with {value} value.");
        }

        public static List<Vehicle> RemoveAuto(string id)
        {
            List<Vehicle> list = ListsOfVehicles.allVehiclesList;
            if (list.Any(vehicle => vehicle.Id == id))
            {
                var vehicle = list.First(v => v.Id == id);
                list.Remove(vehicle);
                Console.WriteLine($"Type: {vehicle.GetType()}, id: {vehicle.Id} has been removed from the list");
                return list;
            }
            throw new RemoveAutoException($"Removal isn't possible. Couldn't find a vehicle with Id {id}.");
        }

        public static List<Vehicle> UpdateAuto(string id, Vehicle newVehicle)
        {
            List<Vehicle> list = ListsOfVehicles.allVehiclesList;
            foreach (var vehicle in list)
            {
                Type myType = vehicle.GetType();

                var idProperty = myType.GetProperty("Id");
                var vehicleId = idProperty.GetValue(vehicle)?.ToString();

                if (id == vehicleId)
                {
                    int index = list.IndexOf(vehicle);
                    list.Remove(vehicle);
                    Console.WriteLine($"Type: {vehicle.GetType()}, id: {vehicle.Id} has been removed from the list");
                    list.Insert(index, newVehicle);
                    Console.WriteLine($"Type: {newVehicle.GetType()}, id: {newVehicle.Id} has been added to the list");
                    return list;
                }
            }
            throw new UpdateAutoException($"Update isn't possible. Couldn't find a vehicle with Id {id}.");
        }

        public static Vehicle AddCarModel(Vehicle vehicle, string carModel)
        {
            Type myType = vehicle.GetType();
            if (myType == typeof(Car))
            {
                Car car = (Car)vehicle;
                if (car.CarModel == null)
                {
                    car.CarModel = carModel;
                    Console.WriteLine($"For {vehicle.GetType()}, id: {vehicle.Id} has been added a car model: {carModel}.");
                    return car;
                }
                else
                {
                    throw new AddException($"For {vehicle.GetType()}, id: {vehicle.Id} cant add a car model: {carModel}" +
                        $" because it already has a car model:{car.CarModel}.");
                }
            }
            throw new AddException($"For {vehicle.GetType()}, id: {vehicle.Id} cant add a car model: {carModel}" +
                       $" because it's not a car.");
        }
    }
}
