using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_19 {
    class Chair : Furniture{

        private int ben;

        public void SetBen(int x) {
            ben = x;
        }
        public int GetBen() {
            return ben;
        }

        public void printInfo() {

            Console.WriteLine("Stol - " + pris + " kr. " + fabrikant + "antal ben: " + ben);
        }
    }
}
