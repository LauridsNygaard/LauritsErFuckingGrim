using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sidstetal_opgave
{
    class Program
    {
        static void Main(string[] args)
        {

            double tal = Convert.ToDouble(Console.ReadLine());
           
           

            string str = Convert.ToString(tal);
            char[] chr = str.ToCharArray();

            Console.WriteLine(chr[chr.Length - 1]);
           
        }
    }
}
