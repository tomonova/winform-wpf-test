using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            string PATH = "../../../SaveFiles/";
            string file = "testis.txt";
            if (!Directory.Exists(PATH))
            {
                Directory.CreateDirectory(PATH);
            }
            StreamWriter sw = new StreamWriter(PATH+file, false);
            Console.WriteLine($"{Path.GetFullPath(PATH+file)}");
        }
    }
}
