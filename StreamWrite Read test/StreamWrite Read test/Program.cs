using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace StreamWrite_Read_test {
    class Program {
        static void Main(string[] args) {

            StreamWriter sw = new StreamWriter("Text.txt", true);
            StreamReader sr = new StreamReader("Text.txt");

            sw.WriteLine(Console.ReadLine());
            sw.Close();
            Console.WriteLine(sr.ReadToEnd());
            sw.Flush();

            

        }

    }
}
