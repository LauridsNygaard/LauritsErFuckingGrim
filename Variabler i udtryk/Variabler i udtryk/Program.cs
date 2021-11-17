using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variabler_i_udtryk
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 20;
            int b = 50;
            int c = 100;
            int result;


            result = c + a * b;

            Console.WriteLine(result);

            result = c * a + 10 - b * 20;
            Console.WriteLine(result);
        }
    }
}
