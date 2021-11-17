using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 3;
            for (n=3;n<50000;n++) {
                for (int i = 1; i <= n / 2; i++) {
                    if (n % i == 0) {
                        
                    }
                    else
                        Console.WriteLine(n);


                }
            }



            
        }
    }
}
