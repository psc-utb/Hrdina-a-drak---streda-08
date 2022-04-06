﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hrdina_a_drak___streda_08
{
    public class ArenaProPostavy
    {
        public List<Postava> Postavy { get; set; }

        public ArenaProPostavy(params Postava[] postavy)
        {
            Postavy = postavy.ToList();
        }

        public ArenaProPostavy(List<Postava> postavy)
        {
            Postavy = postavy;
        }

        public void Boj()
        {
            Bedna bedna = new Bedna(50, 2);
            while (MuzeSeBojovat())
            {
                for (int i = 0; i < Postavy.Count; ++i)
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

                        if (bedna.JeRozbita() == false)
                        {
                            double utok = utocnik.Utok(bedna);
                            Console.WriteLine($"{utocnik.Jmeno} rozbíjí bednu hodnotou {utok}. Bedna má {bedna.Zdravi} životů.");
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
                if (postava.MuzeBojovat() && postava.MuzeSiVybratOponenta(Postavy))
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
