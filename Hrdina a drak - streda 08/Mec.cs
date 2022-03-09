using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___streda_08
{
    public class Mec
    {
        public double PoskozeniMax { get; set; }

        public Mec(double poskozeniMax)
        {
            PoskozeniMax = poskozeniMax;
        }

        public Mec Clone()
        {
            Mec mec = new Mec(PoskozeniMax);
            return mec;
        }
    }
}
