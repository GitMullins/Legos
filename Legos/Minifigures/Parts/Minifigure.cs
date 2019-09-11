using Legos.Minifigures.Parts;
using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.MiniFigures
{
    class Minifigure
    {
        readonly ITalker _talker;
        readonly Torso _torso;
        readonly Legs _legs;


        public Minifigure (ITalker talker, Torso torso, Legs legs)
        {
            _talker = talker;
            _torso = torso;
            _legs = legs;
        }

        public void Battle()
        {
            _legs.Walk();
            _talker.Talk();
            _torso.Flex();
            _torso.Fight();
            _legs.Kick();
        }

    }
}
