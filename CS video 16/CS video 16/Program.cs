using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_video_16
{
    class Program
    {
        static void Main(string[] args)
        {
            double x = Convert.ToDouble(Console.ReadLine());
           
            Køb penge = new Køb();
            Køb remaning = new Køb();

            if (x<100) {
                penge.øv(x);
                Console.WriteLine("Øv jeg har ikke råd");
                double a = penge.øv(x);
                Console.WriteLine("Jeg har "+a+" for lidt");

            }
            else if (x>100) {
                penge.ja(x);
                Console.WriteLine("Ja! jeg har råd");
                double a = penge.ja(x);
                Console.WriteLine("Jeg har " + a + " for meget");
            }
        
            
        }
    }
}
