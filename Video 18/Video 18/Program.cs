using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_18 {
    class Program {
        static void Main(string[] args) {

            Person per = new Person();
            Bog yBog = new Bog();

            per.SetAlder(25);
            per.SetName("per");
            per.SetPenge(2500);

            per.PrintInfo();

            yBog.SetName("NEMPROGRAMMERING");
            yBog.SetSideTal(9);


            per.SetYBog(yBog);

            per.PrintBookInfo();



        }
    }
}
