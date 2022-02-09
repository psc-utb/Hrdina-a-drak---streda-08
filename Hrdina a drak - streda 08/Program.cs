using System;

namespace Hrdina_a_drak___streda_08
{
    class Program
    {
        static void Main(string[] args)
        {
            Hrdina hrdina = new Hrdina("Geralt", 100, 100, 10, 10);
            Drak drak = new Drak("Alduin", 100, 100, 11, 10);
            Arena arena = new Arena(hrdina, drak);
            arena.Boj();
        }
    }
}
