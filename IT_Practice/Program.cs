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
            //EmptyArr();
            ArrThreeElements();
            //FindMaxElementInArray();
            
            
            void FindMaxElementInArray()
            {
                Random rnd = new Random();
                int[] arrNumbers = new int[13];

                for (int i = 0; i < arrNumbers.Length; i++)
                {
                    int rndNumber = rnd.Next(0, 100);
                    arrNumbers[i] = rndNumber;
                }

                int maxValue = 0;

                for (int i = 0; i < arrNumbers.Length; i++)
                {
                    

                    if (maxValue < arrNumbers[i])
                    {
                        maxValue = arrNumbers[i];
                    }
                }
                Console.WriteLine(maxValue);
                Console.Read();
            }

            void ArrThreeElements()
            {
                object[] arrObj = new object[] { 32, 'A', "Hello" };

                foreach (var item in arrObj)
                {
                    Console.WriteLine(item);
                }

                arrObj[0] = (int)arrObj[0] + 10;
                arrObj[2] = arrObj[2] + ", guys!";

                foreach (var item in arrObj)
                {
                    Console.WriteLine(item);
                }

                Console.Read();
            }

            void EmptyArr()
            {
                int[] emptyArr = new int[0];
                Console.WriteLine(emptyArr.Length);
                Console.Read();
            }
        }
    }
}
