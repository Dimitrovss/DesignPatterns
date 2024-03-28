using System;

namespace CarFactoryExample
{
    class MainApp
    {
        static void Main()
        {
            CarFactory[] carFactories = new CarFactory[2];

            carFactories[0] = new SedanCarFactory();
            carFactories[1] = new SUVCarFactory();

            foreach (CarFactory carFactory in carFactories)
            {
                Car car = carFactory.AssembleCar();
                Console.WriteLine("Assembled a {0}", car.GetType().Name);
                car.StartEngine();
            }

            Console.ReadKey();
        }
    }

    abstract class Car
    {
        public abstract void StartEngine();
    }

    class SedanCar : Car
    {
        public override void StartEngine()
        {
            Console.WriteLine("Sedan car engine started.");
        }
    }

    class SUVCar : Car
    {
        public override void StartEngine()
        {
            Console.WriteLine("SUV car engine started.");
        }
    }

    abstract class CarFactory
    {
        public abstract Car AssembleCar();
    }

    class SedanCarFactory : CarFactory
    {
        public override Car AssembleCar()
        {
            return new SedanCar();
        }
    }

    class SUVCarFactory : CarFactory
    {
        public override Car AssembleCar()
        {
            return new SUVCar();
        }
    }
}