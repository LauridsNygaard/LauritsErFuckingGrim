using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_øvelsen {
    class Fire : Type{

        private int fireAttack;

        public void setFireAttack(int x) {
            fireAttack = x;
        }

        public int getFireAttack() {
            return fireAttack;
        }
    }
}
