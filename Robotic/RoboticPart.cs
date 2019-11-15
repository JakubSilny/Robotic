using System;
using System.Collections.Generic;
using System.Text;

namespace Robotic
{
    abstract class RoboticPart
    {
        List<string> parts = new List<string>();
        protected double BasicConsumption;
        
        protected  int consumption;

        public RoboticPart(int _consumption)
        {a
            consumption = _consumption;
        }
        
    }
}
