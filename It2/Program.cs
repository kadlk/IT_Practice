using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace It2
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car();
            car.Move(221);
            var type = car.GetType();

            Transport car2 = new Car();
            var currentFuel = (Car)car2;

        }
    }

    public abstract class Transport
    {
        public int Odometr { get; set; }

        public abstract void Move(int km);
    }

    public class Car : Transport
    {
        public int Fuel { get; set; }

        public override void Move(int km)
        {
            throw new NotImplementedException();
        }
    }
}
