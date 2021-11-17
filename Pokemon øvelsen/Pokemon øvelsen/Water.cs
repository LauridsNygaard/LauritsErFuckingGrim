using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_øvelsen {
    class Water : Type {

        private int waterAttack;

        public void setWaterAttack(int x) {
            waterAttack = x;
        }

        public int getWaterAttack() {
            return waterAttack;
        }
    }
}
