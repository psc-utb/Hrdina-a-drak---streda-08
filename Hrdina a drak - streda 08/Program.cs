using System;

namespace Hrdina_a_drak___streda_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Hrdina hrdina = new Hrdina("Geralt", 100, 100, 10, 10, null);
            Drak drak = new Drak("Alduin", 100, 100, 11, 10);
            Vlk vlk = new Vlk("Wolf", 50, 50, 5, 5);

            /*Arena arena = new Arena(hrdina, drak);
            arena.Boj();*/

            Postava[] postavy = new Postava[] { hrdina, drak, vlk };
            ArenaProPostavy arena = new ArenaProPostavy(postavy);
            arena.Boj();
        }
    }
}
