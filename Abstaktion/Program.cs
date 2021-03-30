using System;
using System.Collections.Generic;

namespace Abstaktion
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> animals = new List<Animal>();

            var parrot = new Parrot();
            parrot.Color = "Red, yellow";


            var cow = new Cow();
            cow.Color = "Red, yellow";

            animals.Add(parrot);
            animals.Add(cow);

            foreach (var animal in animals)
            {
                animal.Animalsound;
                animal.Move;
                animal.Eat;
            }
        }
    }
}
