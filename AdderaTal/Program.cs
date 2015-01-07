using System;

namespace AdderaTal
{
    class Program
    {
        // Main är den metod där exekveringen börjar
        static void Main(string[] args)
        {
            // Deklaration och initiering av variabler
            int forstaTalet = 27;
            int andraTalet = 15;
            int summa = 0;

            // Summera och tilldela till variabeln summa
            summa = forstaTalet + andraTalet;

            // Två variabler adderas och summan skrivs ut
            Console.WriteLine("Summan är {0}", summa);
        }
    }
}
