using System;

namespace CarPrototypeExample
{
    public class Program
    {
        public static void Main(string[] args)
        {
            // Create two instances and clone each

            SedanCarPrototype sedanPrototype = new SedanCarPrototype("Sedan Prototype");
            SedanCarPrototype clonedSedan = (SedanCarPrototype)sedanPrototype.Clone();
            Console.WriteLine("Cloned: {0}", clonedSedan.Id);

            SUVCarPrototype suvPrototype = new SUVCarPrototype("SUV Prototype");
            SUVCarPrototype clonedSUV = (SUVCarPrototype)suvPrototype.Clone();
            Console.WriteLine("Cloned: {0}", clonedSUV.Id);

            // Wait for user

            Console.ReadKey();
        }
    }

    public abstract class CarPrototype
    {
        private string id;

        public CarPrototype(string id)
        {
            this.id = id;
        }

        public string Id
        {
            get { return id; }
        }

        public abstract CarPrototype Clone();
    }

    public class SedanCarPrototype : CarPrototype
    {
        public SedanCarPrototype(string id)
            : base(id)
        {
        }

        public override CarPrototype Clone()
        {
            return (CarPrototype)this.MemberwiseClone();
        }
    }

    public class SUVCarPrototype : CarPrototype
    {
        public SUVCarPrototype(string id)
            : base(id)
        {
        }

        public override CarPrototype Clone()
        {
            return (CarPrototype)this.MemberwiseClone();
        }
    }
}
