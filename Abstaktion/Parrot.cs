using System;
using System.Collections.Generic;
using System.Text;

namespace Abstaktion
{
    class Parrot : Animal
    {

        public override void animalsound()
        {
            Console.WriteLine("parrot is talking");
        }

        public override void eat()
        {
            Console.WriteLine("parrot is eating sunflower seeds");
        }

        public override void move()
        {
            Console.WriteLine("parrot is flying");
        }
    }
}
