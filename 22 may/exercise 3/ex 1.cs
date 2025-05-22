using System;

using System.Collections.Generic;

// 1. Abstract class Vehicle

abstract class Vehicle

{

    public string VehicleNumber { get; set; }

    public string Brand { get; set; }

    public double RatePerDay { get; set; }

    public virtual double CalculateRent(int days)

    {

        return RatePerDay * days;

    }

}

// 2. Derived class Car

class Car : Vehicle

{

    public override double CalculateRent(int days)

    {

        double baseRent = base.CalculateRent(days);

        double surcharge = 0.1 * baseRent; // 10% surcharge

        return baseRent + surcharge;

    }

}

// Derived class Bike

class Bike : Vehicle

{

    public override double CalculateRent(int days)

    {

        double baseRent = base.CalculateRent(days);

        double surcharge = 0.05 * baseRent; // 5% surcharge

        return baseRent + surcharge;

    }

}

// Derived class Truck

class Truck : Vehicle

{

    public override double CalculateRent(int days)

    {

        double baseRent = base.CalculateRent(days);

        double surcharge = 0.15 * baseRent; // 15% surcharge

        return baseRent + surcharge;

    }

}

// 3. Main method to use polymorphism

class Program

{

    static void Main(string[] args)

    {

        List<Vehicle> vehicles = new List<Vehicle>();

        Car car = new Car

        {

            VehicleNumber = "CAR123",

            Brand = "Toyota",

            RatePerDay = 100

        };

        Bike bike = new Bike

        {

            VehicleNumber = "BIKE456",

            Brand = "Yamaha",

            RatePerDay = 50

        };

        Truck truck = new Truck

        {

            VehicleNumber = "TRUCK789",

            Brand = "Volvo",

            RatePerDay = 200

        };

        vehicles.Add(car);

        vehicles.Add(bike);

        vehicles.Add(truck);

        int rentalDays = 5;

        foreach (var vehicle in vehicles)

        {

            double rent = vehicle.CalculateRent(rentalDays);

            Console.WriteLine($"{vehicle.GetType().Name} ({vehicle.Brand}, {vehicle.VehicleNumber}): Rent for {rentalDays} days = {rent:C}");

        }

    }

}