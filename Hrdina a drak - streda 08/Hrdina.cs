using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___streda_08
{
    public class Hrdina
    {

        public string Jmeno { get; set; }
        public double Zdravi { get; set; }
        public double ZdraviMax { get; set; }
        public double PoskozeniMax { get; set; }
        public double ZbrojMax { get; set; }

        public bool Utekl { get; set; }

        public Hrdina(string jmeno, double zdravi, double zdraviMax, double poskozeniMax, double zbrojMax)
        {
            Jmeno = jmeno;
            Zdravi = zdravi;
            ZdraviMax = zdraviMax;
            PoskozeniMax = poskozeniMax;
            ZbrojMax = zbrojMax;
            Utekl = false;
        }

        /// <summary>
        /// utok hrdiny na draka
        /// </summary>
        /// <param name="oponent">oponent hrdiny - drak</param>
        /// <returns>hodnota utoku</returns>
        /// <exception cref="Exception">dojde k vyjimce, pokud postava utoci a uz nemmuze bojovat</exception>
        public double Utok(Drak oponent)
        {
            if (MuzeBojovat())
            {
                double hodnotaUtok = 0;

                Random rnd = new Random();
                hodnotaUtok = rnd.NextDouble() * PoskozeniMax;
                hodnotaUtok -= oponent.Obrana();
                oponent.SnizZdravi(hodnotaUtok);

                return hodnotaUtok;
            }
            else
                throw new Exception("Hrdina útočí a přitom už nemůže bojovat!");
        }

        public double Obrana()
        {
            double hodnotaObrany = 0;

            //

            return hodnotaObrany;
        }

        public void SnizZdravi(double hodnotaSnizeni)
        {
            if (hodnotaSnizeni > 0)
            {
                Zdravi -= hodnotaSnizeni;
            }
        }

        public bool MuzeBojovat()
        {
            return JeZivy() && Utekl == false;
        }

        public bool JeZivy()
        {
            if (Zdravi > 0)
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
