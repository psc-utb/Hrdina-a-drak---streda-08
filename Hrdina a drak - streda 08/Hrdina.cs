using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___streda_08
{
    public class Hrdina : Postava
    {

        public Mec Mec { get; set; }

        public Hrdina(string jmeno, double zdravi, double zdraviMax, double poskozeniMax, double zbrojMax, Mec mec) : base(jmeno, zdravi, zdraviMax, poskozeniMax, zbrojMax)
        {
            Mec = mec;
        }

        public Hrdina(string jmeno, double zdraviMax, double poskozeniMax, double zbrojMax) : this(jmeno, zdraviMax, zdraviMax, poskozeniMax, zbrojMax, null)
        {
        }

        public override double Utok(IZasazitelny oponent)
        {
            if (Mec != null)
            {
                return Utok(oponent, Mec.PoskozeniMax);
            }
            else
            {
                //return Utok(oponent, PoskozeniMax);
                return base.Utok(oponent);
            }
        }

        public Hrdina Clone()
        {
            Hrdina klon = new Hrdina(this.Jmeno, this.Zdravi, this.ZdraviMax, this.PoskozeniMax, this.ZbrojMax, this.Mec.Clone());
            klon.Utekl = this.Utekl;
            //Hrdina klon = this.MemberwiseClone() as Hrdina;
            //klon.Mec = klon.Mec.Clone();
            return klon;
        }

        public override string ToString()
        {
            if (Mec != null)
                return $"{Jmeno}, Zdravi: {Zdravi}, ZdraviMax: {ZdraviMax}, PoskozeniMax: {PoskozeniMax}, ZbrojMax: {ZbrojMax}, Utekl: {Utekl}, Mec poskozeni: {Mec.PoskozeniMax}, Hodnoceni postavy: {HodnoceniPostavy()}";
            else
                return base.ToString();
        }

        public override bool KontrolaOponentaSpecificka(Postava oponent)
        {
            return true;
        }
    }
}
