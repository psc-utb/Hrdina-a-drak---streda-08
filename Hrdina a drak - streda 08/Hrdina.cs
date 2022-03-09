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
            return $"{Jmeno}, Zdravi: {Zdravi}, ZdraviMax: {ZdraviMax}, PoskozeniMax: {PoskozeniMax}, ZbrojMax: {ZbrojMax}, Utekl: {Utekl}, Mec poskozeni: {Mec.PoskozeniMax}";
        }

    }
}
