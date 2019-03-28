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
            string a = "Hello, guys!";
            string b = "HELLO, guys!";
            
            var res = a.Equals(b, StringComparison.OrdinalIgnoreCase);

            var str1 = "Hello";
            var str2 = "my friend";
            var res1 = string.Compare(str1, str2);

            var culture = System.Globalization.CultureInfo.CurrentCulture;

            Console.WriteLine($"{culture.DisplayName}");

            foreach (var item in culture.DateTimeFormat.DayNames)
            {
                Console.Write($"- {item} ");
            }

            Console.ReadKey();
        }
    }
}
