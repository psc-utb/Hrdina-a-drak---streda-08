using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___streda_08
{
    public class Bedna : IZasazitelny
    {
        public double Zdravi { get; set; }

        public int Odolnost { get; set; }

        public Bedna(double zdravi, int odolnost)
        {
            Zdravi = zdravi;
            Odolnost = odolnost;
        }

        public double Obrana()
        {
            return Odolnost;
        }

        public void SnizZdravi(double hodnotaSnizeni)
        {
            if (hodnotaSnizeni > 0)
            {
                Zdravi -= hodnotaSnizeni;
            }
        }

        public bool JeRozbita()
        {
            if (Zdravi <= 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
