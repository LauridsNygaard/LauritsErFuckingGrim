using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace En_lille_sjov_en
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 2;

            for (int i = 0; i >-1; i++) {
                double y = Convert.ToInt32(Math.Pow(x,i));
                Console.WriteLine(x + "^" + i + " = " + y);
            }
        }
    }
}
