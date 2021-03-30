using System;
using System.Collections.Generic;
using System.Text;

namespace Abstaktion
{
    class Cow : Animal
    {
        public Cow()
            {
            int Numberoflegs = 4;
            string Color = Red;
        }
        public override void animalsound()
        {
            throw new NotImplementedException();
        }

        public override void eat()
        {
            throw new NotImplementedException();
        }

        public override void move()
        {
            throw new NotImplementedException();
        }
    }
}
