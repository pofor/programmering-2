using System;
using System.Collections.Generic;
using System.Text;

namespace Abstaktion
{
    abstract class Animal
    {
        public int Numberoflegs { get; set; }
        public int Color { get; set; }
        public abstract void Animalsound();

        public abstract void Move();

        public abstract void Eat();
    }
}
