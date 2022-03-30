using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___streda_08
{
    public interface IZasazitelny
    {
        double Zdravi { get; set; }
        double Obrana();
        void SnizZdravi(double hodnotaSnizeni);
    }
}
