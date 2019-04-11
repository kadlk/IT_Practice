using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Motocyrcle motocyrcle = new Motocyrcle();

            FuelBike fuelBike = new FuelBike();
            fuelBike.ShowVinNumber();
            fuelBike.Move(45);

            Motocyrcle bike = new FuelBike()
            {
                Tank = 17,
                Distance = 100,
                Fuel = 55,
                FuelUsage = 6.0f,
                Weight = 110
            };

            var type = bike.GetType();
            var baseType = bike.GetType().BaseType;
        }
    }

    public class Motocyrcle
    {
        public uint Weight { get; set; }
        public uint Distance { get; set; }

        protected Guid VinNumber { get; private set; }

        public Motocyrcle()
        {
            VinNumber = Guid.NewGuid();
        }

        internal virtual void Move(uint km)
        {
            Distance += km;
        }
    }

    internal class FuelBike : Motocyrcle
    {
        internal int Tank { get; set; }
        internal float Fuel { get; set; }
        internal float FuelUsage { get; set; }

        internal override void Move(uint km)
        {
            base.Move(km);

            Fuel -= km * FuelUsage / 100;
        }

        internal void ShowVinNumber()
        {
            Console.WriteLine(VinNumber);
        }
    }

}
