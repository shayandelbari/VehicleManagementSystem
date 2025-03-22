﻿using Constants;
using Exceptions;

namespace Vehicles;

public class CargoAirplane : Airplane
{
    private double cargoCapacity;
    public double CargoCapacity
    {
        get { return cargoCapacity; }
        set
        {
            if (value < 0) throw new InvalidCargoCapacityException("Cargo capacity cannot be negative!");
            cargoCapacity = value;
        }
    }

    public CargoAirplane(string name, double price, double speed, double altitude, double cargoCapacity)
        : base(name, price, speed, altitude)
    {
        CargoCapacity = cargoCapacity;
    }

    public override void DisplayInfo()
    {
        base.DisplayInfo();
        Console.WriteLine($"Cargo Capacity: {CargoCapacity} kg");
    }

    public override double CalculateTax() => Price * VehicleConstants.TaxRates.AirplaneTaxRate;
}
