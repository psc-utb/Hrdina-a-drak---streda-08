using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___streda_08
{
    public abstract class Postava : Object, IComparable<Postava>, IZasazitelny
    {
        public string Jmeno { get; set; }
        public double Zdravi { get; set; }
        public double ZdraviMax { get; set; }
        public double PoskozeniMax { get; set; }
        public double ZbrojMax { get; set; }

        public bool Utekl { get; set; }

        public Postava(string jmeno, double zdravi, double zdraviMax, double poskozeniMax, double zbrojMax)
        {
            Jmeno = jmeno;
            Zdravi = zdravi;
            ZdraviMax = zdraviMax;
            PoskozeniMax = poskozeniMax;
            ZbrojMax = zbrojMax;
            Utekl = false;
        }

        /// <summary>
        /// utok postavy na oponenta
        /// </summary>
        /// <param name="oponent">oponent postavy</param>
        /// <returns>hodnota utoku</returns>
        /// <exception cref="Exception">dojde k vyjimce, pokud postava utoci a uz nemuze bojovat</exception>
        public virtual double Utok(IZasazitelny oponent)
        {
            return Utok(oponent, PoskozeniMax);
        }

        protected double Utok(IZasazitelny oponent, double poskozeniMax)
        {
            if (MuzeBojovat())
            {
                double hodnotaUtok = 0;

                Random rnd = new Random();
                hodnotaUtok = rnd.NextDouble() * poskozeniMax;
                hodnotaUtok -= oponent.Obrana();
                oponent.SnizZdravi(hodnotaUtok);

                return hodnotaUtok;
            }
            else
                throw new Exception($"{Jmeno} útočí a přitom už nemůže bojovat!");
        }

        public virtual double Obrana()
        {
            double hodnotaObrany = 0;

            //

            return hodnotaObrany;
        }

        public virtual Postava VyberOponenta(List<Postava> postavy)
        {
            foreach (var postava in postavy)
            {
                if (postava.MuzeBojovat() && postava != this && KontrolaOponentaSpecificka(postava))
                {
                    return postava;
                }
            }

            return null;
        }

        public abstract bool KontrolaOponentaSpecificka(Postava oponent);

        public bool MuzeSiVybratOponenta(List<Postava> postavy)
        {
            Postava oponent = VyberOponenta(postavy);
            if (oponent != null)
                return true;
            else
                return false;
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

        public override string ToString()
        {
            return $"{Jmeno}, Zdravi: {Zdravi}, ZdraviMax: {ZdraviMax}, PoskozeniMax: {PoskozeniMax}, ZbrojMax: {ZbrojMax}, Utekl: {Utekl}, Hodnoceni postavy: {HodnoceniPostavy()}";
        }

        public int CompareTo(Postava other)
        {
            if (other == null)
                return 1;

            return this.HodnoceniPostavy().CompareTo(other.HodnoceniPostavy());
        }

        public virtual double HodnoceniPostavy()
        {
            return 0.3 * Zdravi + 0.4 * PoskozeniMax + 0.3 * ZbrojMax;
        }
    }
}
