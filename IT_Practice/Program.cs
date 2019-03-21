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
            //ArrThreeElements();
            FindMaxElementInArray();
            
            
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
            }

            void ArrThreeElements()
            {
                string[] arr = new string[] {"32", "A", "Hello" };

                foreach (var item in arr)
                {
                    Console.WriteLine(item);
                }

                arr[0] = Convert.ToString((Convert.ToInt32(arr[0]) + 10));
                arr[2] = arr[2] + ", guys!";

                foreach (var item in arr)
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
