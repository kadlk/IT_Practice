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
            UniqueItem uniqueItem = new UniqueItem(8);
            UniqueItem uniqueItem2 = new UniqueItem();
            UniqueItem uniqueItem3 = new UniqueItem();
            UniqueItem uniqueItem4 = new UniqueItem();
            UniqueItem uniqueItem5 = new UniqueItem();
            Console.WriteLine(UniqueItem.Id);
            
            Console.ReadLine();
        }
    }

    class UniqueItem
    {
        public static int Id { get; set; }

        public UniqueItem()
        {
            Id++;
        }

        public UniqueItem(int id)
        {
            Id = id++;
        }
    }
}
