using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    interface ITalker
    {
        void Talk();
    }

    interface IShouter : ITalker
    {
        void Shout(int numberOfDecibels);
    }
}
