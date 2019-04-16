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
            UniqueItem uniqueItem = new UniqueItem();
            UniqueItem uniqueItem2 = new UniqueItem();
            UniqueItem uniqueItem3 = new UniqueItem();
            Console.WriteLine(uniqueItem.Id);
            Console.WriteLine(uniqueItem2.Id);
            Console.WriteLine(uniqueItem3.Id);

            Console.ReadLine();
        }
    }

    class UniqueItem
    {
        public int Id { get; set; }
        public int IdTemp { get; set; }

        public UniqueItem()
        {
            Id = IdTemp;
            Id++;
            IdTemp = Id;
        }

        public UniqueItem(int id)
        {
            Id = id;
            id++;
            IdTemp = id;
        }
    }
}
