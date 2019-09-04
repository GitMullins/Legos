using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    abstract class Head
    {
        public int NumberOfEyes { get; set; }
        public string EyeColor { get; set; }
        public bool HasNose { get; set; }
        public string HairColor {get; set; }
        public bool MouthIsOpen { get; set; }
        public HeadSize Size { get; protected set; }

        public virtual void Talk()
        {
            Console.WriteLine("I'm a talking head");
        }

        public abstract void Think();
        //anything that inherits from this Head class has to also have a Think() method.
    }
}
