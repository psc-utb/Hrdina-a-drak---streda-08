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

        
    }
}
