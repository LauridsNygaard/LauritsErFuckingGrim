using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_19 {
    class Program {
        static void Main(string[] args) {

            Chair stol = new Chair();
            Furniture møbel = new Furniture();
            Computer PC = new Computer();

            møbel.SetFabrikant("Samsung");
            møbel.SetPris(100);


            stol.SetPris(300);
            stol.SetFabrikant("ILVA");
            stol.SetBen(4);

            PC.SetFabrikant("ASUS");
            PC.SetPris(4000);
            PC.SetGPU("970 GTX");

            møbel.printInfo();
            stol.printInfo();
            PC.printInfo();

        }
    }
}
