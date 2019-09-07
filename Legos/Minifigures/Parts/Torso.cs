using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    abstract class Torso
        // THIS IS THE BASE CLASS
    {
        public HandType HandType { get; set; }
        public abstract bool ChestHair { get; }
        public string Shirt { get; set; }
        public int NumberOfArms { get; set; }

        public abstract void Flex();
        public abstract void Fight();
        // ^^ this is overriding
    }
}
