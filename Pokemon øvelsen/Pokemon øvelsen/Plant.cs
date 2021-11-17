using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_øvelsen {
    class Plant : Type{

        private int plantAttack;

        public void setPlantAttack(int x) {
            plantAttack = x;
        }

        public int getPlantAttack() {
            return plantAttack;
        }
    }
}
