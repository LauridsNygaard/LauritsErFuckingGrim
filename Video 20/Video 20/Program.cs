using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Video_20 {
    class Program {
        static void Main(string[] args) {

            Person marie = new Person(15,"Marie","Mørkt");
            Person Kristan = new Person("Kristian");

            marie.printInfo();
            Kristan.printInfo();
        }
    }
}
