using System;

namespace CarAbstractFactoryExample
{
    class MainApp
    {
        public static void Main()
        {
            CarFactory factory1 = new EconomyCarFactory();
            Client client1 = new Client(factory1);
            client1.Run();

            CarFactory factory2 = new LuxuryCarFactory();
            Client client2 = new Client(factory2);
            client2.Run();

            Console.ReadKey();
        }
    }

    abstract class CarFactory
    {
        public abstract Car AssembleCar();
    }

    class EconomyCarFactory : CarFactory
    {
        public override Car AssembleCar()
        {
            return new EconomyCar();
        }
    }

    class LuxuryCarFactory : CarFactory
    {
        public override Car AssembleCar()
        {
            return new LuxuryCar();
        }
    }

    abstract class Car
    {
        public abstract void DisplayInfo();
    }

    class EconomyCar : Car
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("This is an economy car.");
        }
    }

    class LuxuryCar : Car
    {
        public override void DisplayInfo()
        {
            Console.WriteLine("This is a luxury car.");
        }
    }

    class Client
    {
        private Car _car;

        public Client(CarFactory factory)
        {
            _car = factory.AssembleCar();
        }

        public void Run()
        {
            _car.DisplayInfo();
        }
    }
}
