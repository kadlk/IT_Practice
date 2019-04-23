using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Practice
{
    public sealed class Motocyrcle
    {
        public int Acceleration { get; set; }
        public int Distance { get; set; }

        public void Move(int km)
        {
            Acceleration = 1;
            Distance += km;
        }
    }
}
