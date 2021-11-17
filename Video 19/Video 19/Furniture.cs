using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_19 {
    class Furniture {

        protected int pris;
        protected string fabrikant;

        public void SetPris(int x) {
            pris = x;
        }

        public int GetPris() {
            return pris;
        }

        public void SetFabrikant(string x) {
            fabrikant = x;
        }

        public void printInfo() {
            Console.WriteLine("Furniture - " + pris + " kr. " + fabrikant);
        }
    }
}
