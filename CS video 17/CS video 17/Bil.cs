using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_video_17
{
    class Bil
    {
        private int årgang;
        private int pris;
        private int udbetaling;
        private string mærke;
        

        public bool Betaling()
        {
            if (this.udbetaling < this.pris) {
                return false;
            }

            else {
                return true;
            }

        }
        public bool BilAlder()
        {
            if (10 <= 2021 - GetÅrgang())
                return true;

            else if (10 > 2021 - GetÅrgang()) ;
            return false;

        }

        public void SetÅrgang(int årgang)
        {
            this.årgang = årgang;
        }

        public int GetÅrgang()
        {
            return årgang;
        }

        public void SetPris(int pris)
        {
            this.pris = pris;
        }

        public int GetPris()
        {
            return this.pris;
        }

        public void SetUdbetaling(int udbetaling)
        {
            this.udbetaling = udbetaling;
        }

        public int GetUdbetaling()
        {
            return this.udbetaling;
        }

        public void SetMærke(string mærke)
        {
            this.mærke = mærke;
        }

        public string GetMærke()
        {
            return mærke;
        }
    }
}
