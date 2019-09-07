using System;
using Legos.MiniFigures;
using Legos.Minifigures.Parts;

namespace Legos
{
    class Program
    {
        static void Main(string[] args)
        {
            var head = new YodaHead
            {
                EyeColor = "Brown",
                HairColor = "Blue",
                HasNose = false,
                MouthIsOpen = true,
                NumberOfEyes = 3
            };

            //var fatHead = new FatHead();

            //fatHead.Talk();

            /*            switch (minifigure.Head)
                        {
                            case YodaHead h:
                                h.Battle();
                                break;
                        }
            */
            /*            torso.Fight();
                        torso.Flex();
            */
            var torso = new YetiTorso();

            var minifigure = new Minifigure(head,torso);
            minifigure.Battle();
        }
    }
}
