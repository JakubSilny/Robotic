using System;
using System.Collections.Generic;
using System.Text;

namespace Robotic
{
    class Hangar
    {
        public List<RoboticPart> Storage { get; set; }
        public Hangar()
        {
            Storage = new List<RoboticPart>();
            Storage.Add(new RoboticChasis());
        }

        
    }
}
