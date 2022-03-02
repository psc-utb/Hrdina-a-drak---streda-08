using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___streda_08
{
    public class ArenaProPostavy
    {
        public Postava[] Postavy { get; set; }

        public ArenaProPostavy(Postava[] postavy)
        {
            Postavy = postavy;
        }

        public void Boj()
        {
            while (MuzeSeBojovat())
            {
                for (int i = 0; i < Postavy.Length; ++i)
                {
                    Postava utocnik = Postavy[i];
                    if (utocnik.MuzeBojovat())
                    {
                        Postava oponent = utocnik.VyberOponenta(Postavy);
                        if (oponent != null)
                        {
                            double utok = utocnik.Utok(oponent);
                            Console.WriteLine($"{utocnik.Jmeno} zaútočil hodnotou {utok}. {oponent.Jmeno} má {oponent.Zdravi} životů.");
                        }
                    }
                }
                Console.WriteLine(String.Empty);
            }
        }

        public bool MuzeSeBojovat()
        {
            int kolikPostavBojuje = 0;
            foreach (var postava in Postavy)
            {
                if (postava.MuzeBojovat())
                {
                    ++kolikPostavBojuje;
                }
            }

            if (kolikPostavBojuje > 1)
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
