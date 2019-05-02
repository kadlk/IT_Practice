using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IT_Practice
{
    delegate void SendMessage();
    delegate int CalcOperation(int a, int b);

    class Program
    {
        static void Main(string[] args)
        {
            //SendMessage sendMessage = new SendMessage(ShowMessage);
            //sendMessage();
            CalcOperation calcOperation;
            Program program = new Program();
            calcOperation = program.Add;

            //var result = calcOperation(2, 4);
            var result = calcOperation.Invoke(2, 5);

            
            Console.Read();
        }

        static void ShowMessage()
        {
            Console.WriteLine("Hello, world!");
        }

        static void ShowMessage1(string param)
        {

        }

        int Add(int arg1, int arg2)
        {
            return arg1 + arg2;
        }
    }
}
