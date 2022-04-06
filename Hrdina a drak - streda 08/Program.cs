using System;
using System.Collections.Generic;

namespace Hrdina_a_drak___streda_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Mec mec = new Mec(20);
            Hrdina hrdina = new Hrdina("Geralt", 100, 100, 10, 10, mec);
            Hrdina hrdina2 = new Hrdina("Dovahkiin", 100, 10, 10);
            Drak drak = new Drak("Alduin", 100, 100, 11, 10);
            Drak drak2 = new Drak("Šmak", 100, 100, 10, 10);
            Vlk vlk = new Vlk("Wolf", 50, 50, 5, 5);

            Hrdina klon = hrdina.Clone();
            klon.Jmeno += " (klon)";
            klon.Zdravi = 200;
            klon.Utekl = true;
            klon.PoskozeniMax = 15;
            klon.Mec.PoskozeniMax = 50;
            Console.WriteLine(hrdina.ToString());
            Console.WriteLine(klon.ToString());
            Console.WriteLine(String.Empty);

            /*Arena arena = new Arena(hrdina, drak);
            arena.Boj();*/

            List<Postava> postavy = new List<Postava> { hrdina, drak, drak2, hrdina2, vlk };

            postavy.Add(new Hrdina("hrdina 5", 100, 5, 5));
            //Array.Sort(postavy);
            //Array.Reverse(postavy);
            postavy.Sort();
            postavy.Reverse();

            postavy.Remove(drak2);
            postavy.RemoveAt(1);
            foreach(var postava in postavy)
            {
                Console.WriteLine(postava.ToString());
            }
            Console.WriteLine(String.Empty);
            
            ArenaProPostavy arena = new ArenaProPostavy(postavy);
            arena.Boj();
        }
    }
}
