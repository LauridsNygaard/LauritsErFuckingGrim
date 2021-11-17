using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Udvidet_kontrolstruktur
{
    class Program
    {
        static void Main(string[] args)
        {
            
            /*
            int x = 20;
            int y = 55;

            int z = Convert.ToInt32(Console.ReadLine());

            

            if (x > y && x > z) {
                Console.WriteLine(x);
            }

            else if (y > x && y > z) { 
                Console.WriteLine(y);
            }

            else if (z > x && z > y) {
                Console.WriteLine(z);
            }
            */
            
            
            for (int i = 0; i<= 25; i++) {
                if (i % 2 == 0)
                    continue;
                        Console.WriteLine(i);
            }
            
            
            
        }
    }
}