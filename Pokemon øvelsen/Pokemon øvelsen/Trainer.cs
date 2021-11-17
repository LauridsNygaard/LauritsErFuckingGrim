using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_øvelsen {
    class Trainer {
        private string navn;
        Pokeball a;
        Pokeball b;
        Pokeball c;
        Pokeball d;

        public void SetNavn(string x) {
            navn = x;

        }

        public string GetNavn() {
            return navn;
        }
        public void SetPokeball1(Pokeball x) {
            a = x;
        }

        public Pokeball GetPokeball1() {
            return a;
        }

        public void SetPokeball2(Pokeball x) {
            b = x;
        }
        public Pokeball GetPokeball2() {
            return b;
        }
        public void SetPokeball3(Pokeball x) {
            c = x;
        }
        public Pokeball GetPokeball3() {
            return c;
        }
        
        public void SetPokeball4(Pokeball x) {
            d = x;
        }
        public Pokeball GetPokeball4() {
            return d;
        }
        public void PrintInfo() {
            Console.WriteLine(navn);
            Console.WriteLine("Pokeball Id: " + a.GetId() + " Er den fuld? " + a.GetIsFull());
            Console.WriteLine("Pokeball Id: " + b.GetId() + " Er den fuld? " + b.GetIsFull());
            Console.WriteLine("Pokeball Id: " + c.GetId() + " Er den fuld? " + c.GetIsFull());
            Console.WriteLine("Pokeball Id: " + d.GetId() + " Er den fuld? " + d.GetIsFull());
        }



    }
}
