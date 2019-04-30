using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IT_Practice
{
    class Program
    {
        static void Main(string[] args)
        {
            Text.WindowsCopy();

            FileInfo fileinfo = new FileInfo(@"D:\students\Kontush\Projects\kadlk\IT_Practice\Parser_testing\bin\Debug\txt.txt");

            //var name = fileinfo.Name;
            //var length = fileinfo.Length;
            //var canWrite = fileinfo.CreationTime;
            //var creationTimeUtc = fileinfo.CreationTimeUtc;

            FileStream fs = fileinfo.Open(FileMode.OpenOrCreate, FileAccess.ReadWrite);

            byte[] guys = Encoding.Default.GetBytes("Hello Guys!");
            fs.Write(guys, 0, guys.Length);
            fs.Close();

            fs = fileinfo.Open(FileMode.Open, FileAccess.Read);
            byte[] text = new byte[fs.Length];
            fs.Read(text, 0, (int)fs.Length);
            fs.Close();
            Console.WriteLine(Encoding.Default.GetChars(text));

            Console.Read();
        }
    }
}
