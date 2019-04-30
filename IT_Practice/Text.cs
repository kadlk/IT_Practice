using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace IT_Practice
{
    class Text
    {
        public static void GetDirectoryInfo()
        {
            DirectoryInfo fileinfo = new DirectoryInfo(@"C:\Program Files");

            Console.WriteLine($"Creation date: {fileinfo.CreationTimeUtc}");
        }

        public static void GetDirectoryFiles()
        {
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Windows");

            FileInfo[] fileInfos = dirinfo.GetFiles();

            foreach (var item in fileInfos)
            {
                Console.WriteLine(item.Name);
            }
        }

        public static void WindowsCopy()
        {
            const string NewDirectoryName = @"C:\WindowsCopy";
            Directory.CreateDirectory(NewDirectoryName);
            DirectoryInfo dirinfo = new DirectoryInfo(@"C:\Windows");
            var firstFile = dirinfo.GetFiles().FirstOrDefault();

            firstFile.CopyTo(NewDirectoryName + "\\" + firstFile);
        }
    }
}
