using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Vehicle> vehicles = new List<Vehicle>();
            Car myCar = new Car { Year = "2023", Make = "Toyota", Model = "Corolla", HasTrunk = true };
            Motorcycle myMotorcycle = new Motorcycle { Year = "2022", Make = "Harley Davidson", Model = "Road King", HasSideCart = false };

            vehicles.Add(myCar);
            vehicles.Add(myMotorcycle);

            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"Vehicle: {vehicle.Year} {vehicle.Make} {vehicle.Model}");
                vehicle.DriveAbstract();
                vehicle.DriveVirtual();
            }

            Console.ReadKey();
        }

            /*
             * Create an abstract class called Vehicle
             * The vehicle class shall have three string properties Year, Make, and Model
             * Set the defaults to something generic in the Vehicle class
             * Vehicle shall have an abstract method called DriveAbstract with no implementation
             * Vehicle shall have a virtual method called DriveVirtual with a base implementation.
            */
        
        public abstract class Vehicle
        {
            public string Year { get; set; } = "2022";
            public string Make { get; set; } = "Ford";
            public string Model { get; set; } = "F150";

            public abstract void DriveAbstract();

            public virtual void DriveVirtual()
            {
                Console.WriteLine($"Driving {Year} {Make} {Model}");
            }
        }

         /* 
             * Now create 2 non-abstract classes: Car and Motorcycle, that inherit from Vehicle
             * Add a distict property in the 2 derived classes such as HasTrunk for Car and HasSideCart for Motorcycle
             * Provide the implementations for the abstract methods
             * Only in the Motorcycle class will you override the virtual drive method
        */

        public class Car : Vehicle
        {
            public bool HasTrunk { get; set; }

            public override void DriveAbstract()
            {
                Console.WriteLine($"Driving the {Year} {Make} {Model} on the road");
            }

            public override void DriveVirtual()
            {
                Console.WriteLine($"Driving virtually in a {Year} {Make} {Model} car");
            }
        }

        public class Motorcycle : Vehicle
        {
            public bool HasSideCart { get; set; }

            public override void DriveAbstract()
            {
                Console.WriteLine($"Driving the {Year} {Make} {Model} on the road with two wheels");
            }

            public override void DriveVirtual()
            {
                Console.WriteLine($"Driving virtually in a {Year} {Make} {Model} motorcycle with two wheels");
            }
        }

    // End vehicle class
    }
}
