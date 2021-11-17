using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_øvelsen {
    class Electric : Type {

        private int electricAttack;

        public void setElectricAttack(int x) {
            electricAttack = x;
        }

        public int getElectricAttack() {
            return electricAttack;
        }
    }
}
