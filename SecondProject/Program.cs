using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using IT_Practice;
using SecondProject.Extensions;

namespace SecondProject
{
    class Program
    {
        static void Main(string[] args)
        {
            Motocyrcle moto = new Motocyrcle();
            moto.Move(23);
            moto.TakeWheelie(10);
        }
    }

    //class CustomMoto : Motocyrcle
    //{

    //}
}
