using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budjetti
{
    class Tulot
    {
        private Tulo[] taulukko = { new Tulo(0, 100), new Tulo(1, 100), new Tulo(2, 100), new Tulo(3, 100), new Tulo(4, 100), };

        public Tulo[] GetTulot()
        {
            return taulukko;
        }

        public void SetTulot(int i, double s)
        {
            taulukko[i].SetSumma(s);
        }

        public int Pituus()
        {
            return taulukko.Length;
        }
    }
}
