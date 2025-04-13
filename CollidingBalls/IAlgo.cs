using System;
using System.Collections.Generic;
using System.Text;

namespace CollidingBalls
{
    public interface IAlgo
    {
        public void NextStep(BBox box);
    }
}
