using System;

namespace hemdatorarray

{
    class Program
    {
        static void Main(string[] args)
        {
            var names = new string[5];

            Console.WriteLine("Skriv 5 namn");

            for(int i = 4; i >= 0; i--)
            {
                names[i] = Console.ReadLine();
            }
            
            foreach (var name in names)
            {
                Console.Write(name + " ");
            }
            Console.ReadKey();
        }
    }
}