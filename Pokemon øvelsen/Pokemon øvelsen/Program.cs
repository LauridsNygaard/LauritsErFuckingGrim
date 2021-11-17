using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_øvelsen {
    class Program {
        static void Main(string[] args) {
            Trainer Ash = new Trainer();
            Pokeball Pokeball1 = new Pokeball();
            Pokeball Pokeball2 = new Pokeball();
            Pokeball Pokeball3 = new Pokeball();
            Pokeball Pokeball4 = new Pokeball();

            Pokeball1.SetId(1);
            Pokeball1.SetIsFull(true);
            Ash.SetPokeball1(Pokeball1);

            Pokeball2.SetId(2);
            Pokeball2.SetIsFull(false);
            Ash.SetPokeball2(Pokeball2);

            Pokeball3.SetId(3);
            Pokeball3.SetIsFull(true);
            Ash.SetPokeball3(Pokeball3);

            Pokeball4.SetId(4);
            Pokeball4.SetIsFull(true);
            Ash.SetPokeball4(Pokeball4);
            Ash.SetNavn("Ash");

            Ash.PrintInfo();




        }
    }
}
