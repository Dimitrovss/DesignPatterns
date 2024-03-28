using System;

namespace CarAdapterExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Car regularCar = new RegularCar();
            regularCar.Drive();


            Car electricCarAdapter = new ElectricCarAdapter(new ElectricCar());
            electricCarAdapter.Drive();

            Console.ReadKey();
        }
    }

    public interface Car
    {
        void Drive();
    }

    public class RegularCar : Car
    {
        public void Drive()
        {
            Console.WriteLine("Driving a regular car.");
        }
    }

    public class ElectricCar
    {
        public void ChargeAndDrive()
        {
            Console.WriteLine("Charging and driving an electric car.");
        }
    }

    public class ElectricCarAdapter : Car
    {
        private ElectricCar electricCar;

        public ElectricCarAdapter(ElectricCar electricCar)
        {
            this.electricCar = electricCar;
        }

        public void Drive()
        {
            electricCar.ChargeAndDrive();
        }
    }
}
