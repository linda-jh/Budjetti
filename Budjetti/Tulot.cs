using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budjetti
{
    class Tulot
    {
        private Tulo[] taulukko = { new Tulo(0, 319.50), new Tulo(1, 251.75), new Tulo(2, 600), new Tulo(3, 123.84), new Tulo(4, 10), };

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
