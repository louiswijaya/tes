using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace tes3
{
    class Program
    {
        static void Main(string[] args)
        {
            DirectoryInfo d = new DirectoryInfo(@"D:\Project\tes3");

            FileInfo[] Files = d.GetFiles("*.txt");
            string str = "";

            foreach (FileInfo file in Files)
            {
                str = str + ", " + file.Name;
            }
            Console.ReadKey();
        }
    }
}
