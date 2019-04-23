using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LastPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Neighbor> neighbors = new List<Neighbor>();

            neighbors.Add(new Neighbor() { FlatNumber = 2, FullName = "Vasya Pup" });
            neighbors.Add(new Neighbor() { FlatNumber = 4, FullName = "Kolya Pup" });
            neighbors.Add(new Neighbor() { FlatNumber = 1, FullName = "Vadim Pup" });
            neighbors.Add(new Neighbor() { FlatNumber = 6, FullName = "Marina Pup" });
            neighbors.Add(new Neighbor() { FlatNumber = 3, FullName = "James Pup" });
            neighbors.Add(new Neighbor() { FlatNumber = 2, FullName = "Asja Pup" });

            Console.WriteLine("Input flat number:");
            var flatNumber = Convert.ToInt32(Console.ReadLine());

            foreach (var item in neighbors)
            {
                if (item.FlatNumber == flatNumber)
                {
                    Console.WriteLine($"Our neighbour {item.FullName} lives in in {flatNumber} ");
                }
            }
        }
    }

    class Neighbor
    {
        public string FullName { get; set; }
        public int FlatNumber { get; set; }
    }
}
