using System;

namespace CarBridgeExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CarAbstraction car = new CarRefinedAbstraction();

            car.CarType = new SedanCar();
            car.Drive();

            car.CarType = new SUVCar();
            car.Drive();

            Console.ReadKey();
        }
    }

    public class CarAbstraction
    {
        protected CarType carType;

        public CarType CarType
        {
            set { carType = value; }
        }

        public virtual void Drive()
        {
            carType.Drive();
        }
    }

    public abstract class CarType
    {
        public abstract void Drive();
    }

    public class CarRefinedAbstraction : CarAbstraction
    {
        public override void Drive()
        {
            carType.Drive();
        }
    }

    public class SedanCar : CarType
    {
        public override void Drive()
        {
            Console.WriteLine("Driving a Sedan car.");
        }
    }

    public class SUVCar : CarType
    {
        public override void Drive()
        {
            Console.WriteLine("Driving an SUV car.");
        }
    }
}
