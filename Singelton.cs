using System;

namespace CarSingletonExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CarFactory factory1 = CarFactory.Instance();
            CarFactory factory2 = CarFactory.Instance();

            if (factory1 == factory2)
            {
                Console.WriteLine("Objects are the same instance");
            }

            Car sedanCar = factory1.CreateCar("Sedan");
            Car suvCar = factory2.CreateCar("SUV");

            Console.WriteLine("Car 1 Type: " + sedanCar.GetType().Name);
            Console.WriteLine("Car 2 Type: " + suvCar.GetType().Name);

            Console.ReadKey();
        }
    }

    public abstract class Car
    {
        public abstract void Assemble();
    }

    public class SedanCar : Car
    {
        public override void Assemble()
        {
            Console.WriteLine("Assembling a Sedan Car");
        }
    }

    public class SUVCar : Car
    {
        public override void Assemble()
        {
            Console.WriteLine("Assembling an SUV Car");
        }
    }

    public class CarFactory
    {
        private static CarFactory instance;

        protected CarFactory()
        {
        }

        public static CarFactory Instance()
        {
            if (instance == null)
            {
                instance = new CarFactory();
            }

            return instance;
        }

        public Car CreateCar(string type)
        {
            switch (type)
            {
                case "Sedan":
                    return new SedanCar();
                case "SUV":
                    return new SUVCar();
                default:
                    throw new ArgumentException("Invalid car type");
            }
        }
    }
}
