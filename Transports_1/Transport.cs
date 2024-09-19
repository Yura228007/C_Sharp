using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Transports_1
{
    using System;
    using System.Collections.Generic;

    public enum FuelType
    {
        hydrogen,
        methane,
        dieselSummer,
        dieselWinter,
        АИ92,
        АИ95,
        АИ98,
        АИ76,
        АИ80
    }

    public abstract class Transport
    {
        private static int _nextId = 1;
        public int Id { get; private set; }
        public string Name { get; set; }
        public int FuelConsumption { get; set; } 
        public int AverageSpeed { get; set; } 

        protected Transport(string name, int fuelConsumption, int averageSpeed)
        {
            Id = _nextId++;
            Name = name;
            FuelConsumption = fuelConsumption;
            AverageSpeed = averageSpeed;
        }

        public abstract FuelType GetFuelType();
    }

    public class PassengerCar : Transport
    {
        public FuelType Fuel { get; set; }

        public PassengerCar(string name, int fuelConsumption, int averageSpeed, FuelType fuel)
            : base(name, fuelConsumption, averageSpeed)
        {
            Fuel = fuel;
        }

        public override FuelType GetFuelType() => Fuel;
    }

    public class Truck : Transport
    {
        public FuelType Fuel { get; set; }

        public Truck(string name, int fuelConsumption, int averageSpeed, FuelType fuel)
            : base(name, fuelConsumption, averageSpeed)
        {
            Fuel = fuel;
        }

        public override FuelType GetFuelType() => Fuel;
    }

    public class Bus : Transport
    {
        public FuelType Fuel { get; set; }

        public Bus(string name, int fuelConsumption, int averageSpeed, FuelType fuel)
            : base(name, fuelConsumption, averageSpeed)
        {
            Fuel = fuel;
        }

        public override FuelType GetFuelType() => Fuel;
    }

}
