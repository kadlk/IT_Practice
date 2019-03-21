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
            EmptyArr();

            void EmptyArr()
            {
                int[] emptyArr = new int[0];
                Console.WriteLine(emptyArr.Length);
                Console.Read();
            }
        }
    }
}
