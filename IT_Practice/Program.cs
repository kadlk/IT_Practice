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
            string input = "0123456weq";
            input = input.StringDelete();
            Console.WriteLine(input);
        }
    }

}
