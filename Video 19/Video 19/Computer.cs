using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_19 {
    class Computer : Furniture{
        private string GPU;

        public void SetGPU(string x) {
            GPU = x;
        }

        public string GetGPU() {
            return GPU;
        }

        public void printInfo() {

            Console.WriteLine("Computer - " + pris + " kr. " + fabrikant + "grafikkort er: " + GPU);
        }
    }
}
