using System;

namespace ageprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv ditt namn");

            string namn = Console.ReadLine();

            Console.WriteLine("Ditt namn är: " + namn);

            Console.WriteLine("Enter your age:");

            int age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Your age is: " + age);

            Console.WriteLine("är du vid liv");

            Console.WriteLine("Lever du: y/n");
            var answer = Console.ReadLine();
            if (answer == "y")
            {
                Console.WriteLine("Bra att du lever");
            }
            else
            {
                Console.WriteLine("Good luck next life pleb!");
            }


        }
    }
}
