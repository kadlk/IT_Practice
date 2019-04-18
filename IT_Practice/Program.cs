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

            try
            {
                Motocyrcle moto = null;

                moto.Fuel = 10;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.GetType()}, StackTrace: {ex.StackTrace}");
                //throw;
            }
            
            Console.Read();
        }
    }
    
    class Motocyrcle
    {
        public int Fuel { get; set; }
    }
}
