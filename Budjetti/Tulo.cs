using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Budjetti
{
    class Tulo
    {
        private int Id;
        private double Summa;

        public Tulo(int i, double s)
        {
            Id = i;
            Summa = s;
        }


        public int GetId()
        {
            return this.Id;
        }
        public double GetSumma()
        {
            return this.Summa;
        }
        public void SetId(int i)
        {
            this.Id = i;
        }
        public void SetSumma(double s)
        {
            this.Summa = s;
        }
    }
}
