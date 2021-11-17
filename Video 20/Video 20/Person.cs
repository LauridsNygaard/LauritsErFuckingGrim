using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_20 {
    class Person {

        private int alder;
        private string name;
        private string hårFarve;

        public Person(int age, string name, string HairColor) {
            alder = age;
            this.name = name;
            hårFarve = HairColor; 
        }

        public Person(string name) : this(0,name,"ikke bestemt") {
        }


        public void printInfo() {
            Console.WriteLine("alder: " + alder + " navn: " + name + " hår farve: " + hårFarve);
        }

    }
}
