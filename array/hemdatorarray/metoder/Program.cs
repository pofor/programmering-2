using System;
using System.Runtime.CompilerServices;
using System.Threading.Channels;

namespace metoder
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(1, 2));
        }

        private static int Add(int tal1, int tal2)
        {
            var sum = tal1 + tal2;

            return sum;
        }
    }
}
// 1. Skapa ett nytt projekt i Solution HelloWorld
// 2.Skriv ett program som har 3 metoder.
//   a.En metod som tar in en lista av heltal och adderar samtliga tal sedan returnerar summan.
//    b.En metod som tar in en lista av ord och skriver ut dem i omvänd ordning
//  c.En metod som tar in en lista av heltal sedan tar reda på det största och det minsta talet och returnera dem.
// 3.Skriv ut samtliga resultat i consolen.
// 4.Comitta och pusha.
// 5.Lämna in.