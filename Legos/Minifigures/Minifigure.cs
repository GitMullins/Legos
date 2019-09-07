using Legos.Minifigures.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.MiniFigures
{
    class Minifigure
    {
        public Head Head { get; set; }

        public Torso Torso { get; set; }

        public Minifigure (Head head, Torso torso)
        {
            Head = head;
            Torso = torso;
        }

        public void Battle()
        {
            Head.Talk();
            Torso.Flex();
            Torso.Fight();
        }

    }
}
