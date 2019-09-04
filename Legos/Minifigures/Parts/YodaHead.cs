using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    class YodaHead : Head
    {
        public bool HasEars { get; private set; }

        public YodaHead()
        {
            Size = HeadSize.Small;
            HasEars = true;
        }

        public override void Talk()
        {
            Console.WriteLine("Talking head I am");
        }

        public override void Think()
        {
            Console.WriteLine("There is no try...");
        }

        public void Battle()
        {
            HasEars = false;
        }

    }
}
