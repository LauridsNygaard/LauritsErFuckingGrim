using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace syntaktisk_sukker_og_klistre_plus
{
    class Program
    {
        static void Main(string[] args)
        {
            int counter = 0;

            counter += 5;
            Console.WriteLine(counter);

            counter++;
                Console.WriteLine(counter);

            /* forskellen ved ++counter og counter++ er at ++counter,
             * tilføjer værdien inden linjen bliver printet eller andet
             * mens den ved counter++ tilføjer værdien efter den bliver skrevet ud eller andet brug
             */

        }
    }
}
