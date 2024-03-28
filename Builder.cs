using System;
using System.Collections.Generic;

namespace CarBuilderExample
{
    public class MainApp
    {
        public static void Main()
        {
            CarDirector director = new CarDirector();

            CarBuilder builder1 = new SedanCarBuilder();
            CarBuilder builder2 = new SUVCarBuilder();

            director.Construct(builder1);
            Car car1 = builder1.GetResult();
            car1.Show();

            director.Construct(builder2);
            Car car2 = builder2.GetResult();
            car2.Show();

            Console.ReadKey();
        }
    }

    class CarDirector
    {
        public void Construct(CarBuilder builder)
        {
            builder.BuildEngine();
            builder.BuildWheels();
            builder.BuildBody();
        }
    }

    abstract class CarBuilder
    {
        protected Car car = new Car();

        public abstract void BuildEngine();
        public abstract void BuildWheels();
        public abstract void BuildBody();

        public Car GetResult()
        {
            return car;
        }
    }

    class SedanCarBuilder : CarBuilder
    {
        public override void BuildEngine()
        {
            car.AddPart("Sedan Engine");
        }

        public override void BuildWheels()
        {
            car.AddPart("Sedan Wheels");
        }

        public override void BuildBody()
        {
            car.AddPart("Sedan Body");
        }
    }

    class SUVCarBuilder : CarBuilder
    {
        public override void BuildEngine()
        {
            car.AddPart("SUV Engine");
        }

        public override void BuildWheels()
        {
            car.AddPart("SUV Wheels");
        }

        public override void BuildBody()
        {
            car.AddPart("SUV Body");
        }
    }

    class Car
    {
        private List<string> parts = new List<string>();

        public void AddPart(string part)
        {
            parts.Add(part);
        }

        public void Show()
        {
            Console.WriteLine("\nCar Parts -------");
            foreach (string part in parts)
                Console.WriteLine(part);
        }
    }
}
