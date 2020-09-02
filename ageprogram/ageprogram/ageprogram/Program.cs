using System;
using System.Threading.Tasks.Dataflow;

namespace ageprogram
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true) {
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
                Console.WriteLine("du har dessa sekunder kvar att leva! P.S du dör på 0");
                for (int i = 5; i > -1; i--)
                {
                    Console.WriteLine(i);
                }
                Console.WriteLine("Du är du död välj vilket öde du får! Skriv himlen eller helvete för att välja");
                var hell = Console.ReadLine();
                switch (hell)
                {                    
                    case "helvete":
                        Console.WriteLine("du kom till himlen");
                        break;
                    case "himlen":
                        Console.WriteLine("du kom till helvetet.");
                        break;
                    default:
                        Console.WriteLine("Skit i det då...");
                        break;
                }
                break;
            }
        }

    }
}
