using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_video_17
{
    class Program
    {
        static void Main(string[] args)
        {

            Bil årgang = new Bil();
            Bil pris = new Bil();
            Bil udbetaling = new Bil();
            Bil mærke = new Bil();
            Bil kankøbe = new Bil();

            bool x = true;

            

            Console.WriteLine("Vælg årgang:");
            årgang.SetÅrgang(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Vælg pris:");
            pris.SetPris(Convert.ToInt32(Console.ReadLine()));

            Console.WriteLine("Vælg mærke:");
            mærke.SetMærke(Console.ReadLine());

            if (årgang.BilAlder()==false) {
                Console.WriteLine("Den er ikke for gammel, du må gerne købe bilen.");
                harRåd();

            }
            else if (årgang.BilAlder() == true) {
                Console.WriteLine("Du må ikke købe bilen, den er for gammel");
            }

            void harRåd() {
                Console.WriteLine("Hvor mange penge har du?");
                udbetaling.SetUdbetaling(Convert.ToInt32(Console.ReadLine()));

                if (pris.GetPris()>udbetaling.GetUdbetaling()) {
                    Console.WriteLine("Du har desværre ikke råd til at købe bilen....");
                }

                else {
                    Console.WriteLine("Tillykke, du kan købe bilen!");
                    Console.WriteLine("Her er din nye bil:");
                    Console.WriteLine("Årgang: " + årgang.GetÅrgang());
                    Console.WriteLine("Pris: " + pris.GetPris());
                    Console.WriteLine("Mærke: " + mærke.GetMærke());
                }
                
            }
        }
    }
}
