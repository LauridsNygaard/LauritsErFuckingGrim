using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace int__char__float_og_double
{
    class Program
    {
        static void Main(string[] args)
        {
            double myDbl = 420.69;
            int myInt = -55;
            char myChar = 'L';

            Console.WriteLine(myDbl);
            Console.WriteLine(myInt);
            Console.WriteLine(myChar);

            Console.ReadKey();

            /* for værdien 1054, kan der bruges enten dbl eller int
             * for værdien -522, kan der bruges dbl eller int
             * for værdien 1.234 kan der bruges dbl
             * for værdien k kan der bruges char
             * for værdien -4.3 kan der bruges dbl
             * for værdien y kan der bruges dbl eller int
             * for værdien 19488 kan der bruges dbl eller int
             */
        }
    }
}
