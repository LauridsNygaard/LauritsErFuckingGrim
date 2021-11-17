using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_18 {
    class Person {

        private int alder;
        private string name;
        private double penge;
        Bog yBog;


        public void SetYBog(Bog yBog) {
            this.yBog = yBog;
        }

        public Bog GetYBog() {
            return yBog;
        }

        public void SetAlder(int x) {
            alder = x;
        }

        public int GetAlder() {
            return alder;
        }

        public void SetName(string x) {
            name = x;
        }

        public string GetName() {
            return name;
        }

        public void SetPenge(double x) {
            penge = x;
        }

        public double GetPenge() {
            return penge;
        }

        public void PrintInfo() {
            Console.WriteLine("[navn] - " + name);
            Console.WriteLine("[alder] - " + alder);
            Console.WriteLine("[penge] - " + penge);
        }

        public void PrintBookInfo() {
            if (yBog != null)
                Console.WriteLine("personens ynglings bog er " + yBog.GetName() + " bogen er " + yBog.GetSideTal() + " sider lang");
        }
    }
}
