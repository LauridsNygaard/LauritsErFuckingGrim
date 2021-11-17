using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace If_else_statemens
{
    class Program
    {
        static void Main(string[] args)
        {

            /* int x = 42, y = 64, result = 100;

             if(x+y > result)
             {
                 Console.WriteLine("Summen er større end 100!");
             }
             else
             {
                 Console.WriteLine("Summen er mindre end 100");
             }
            */
            int dice = 3;
            if (dice == 1)
                Console.WriteLine("ener");
            else if (dice == 2)
                Console.WriteLine("toer");
            else if (dice == 3)
                Console.WriteLine("treer");
            else if (dice == 4)
                Console.WriteLine("fire");
            else if (dice == 5)
                Console.WriteLine("femer");
            else if (dice == 6)
                Console.WriteLine("sekser");


        }
    }
}
