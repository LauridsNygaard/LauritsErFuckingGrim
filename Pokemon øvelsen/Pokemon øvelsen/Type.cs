using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_øvelsen {
    class Type {
        protected string navn;
        protected int level;
        protected int attack;
        
        public void setNavn(string x) {
            navn = x;
        }
        public string getNavn() {
            return navn; 
        }
        public void setLevel(int x) {
            level = x;
        }
        public int getLevel() {
            return level;
        }
        public void setAttack(int x) {
            attack = x;
        }
        public int getAttack() {
            return attack;
        }


    }
}
