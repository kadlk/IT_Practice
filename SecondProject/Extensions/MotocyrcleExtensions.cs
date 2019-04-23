using IT_Practice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondProject.Extensions
{
    public static class MotocyrcleExtensions
    {
        public static void TakeWheelie(this Motocyrcle moto, int acceleration)
        {
            moto.Acceleration = acceleration;
        }
    }
}
