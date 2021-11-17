using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace switch_statements
{
    class Program
    {
        static void Main(string[] args)
        {

            Random rand = new Random();
             int dice = rand.Next(20);

            switch(dice) {
                case 1:
                    Console.WriteLine("ener");
                    break;
                case 2:
                    Console.WriteLine("toer");
                    break;
                case 3:
                    Console.WriteLine("treer");
                    break;
                case 4:
                    Console.WriteLine("fire");
                    break;
                case 5:
                    Console.WriteLine("femer");
                    break;
                case 6:
                    Console.WriteLine("sekser");
                    break;
                default:
                    Console.WriteLine("magiskterning");
                    break;

                    Console.ReadKey();

            }
        }
    }
}
