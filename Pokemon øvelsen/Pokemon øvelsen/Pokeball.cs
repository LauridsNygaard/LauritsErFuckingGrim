using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokemon_øvelsen {
    class Pokeball {

        bool IsFull;
        int Id;

        public void SetIsFull(bool x) {
            IsFull = x;
        }

        public bool GetIsFull() {
            return IsFull;
        }

        public void SetId(int x) {
            Id = x;
        }

        
        public int GetId() {
            return Id;
        }


    }
}
