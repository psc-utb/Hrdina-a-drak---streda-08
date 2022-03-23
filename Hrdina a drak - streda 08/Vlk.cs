using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___streda_08
{
    public class Vlk : Postava
    {
        public Vlk(string jmeno, double zdravi, double zdraviMax, double poskozeniMax, double zbrojMax) : base(jmeno, zdravi, zdraviMax, poskozeniMax, zbrojMax)
        {
        }

        public override bool KontrolaOponentaSpecificka(Postava oponent)
        {
            return oponent is not Vlk;
        }
    }
}
