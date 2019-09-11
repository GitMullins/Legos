using System;
using System.Collections.Generic;
using System.Text;

namespace Legos.Minifigures.Parts
{
    interface DrillSergeant : IShouter
    {
        public void Talk()
        {
            throw new NotImplementedException();
        }

        public void Shout(int numberOfDecibels)
        {
            throw new NotImplementedException();
        }
    }
}
