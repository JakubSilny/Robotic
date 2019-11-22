using System;
using System.Collections.Generic;
using System.Text;

namespace Robotic
{
    abstract class RoboticPart
    {
        public virtual string StatusMessage { get { return "This is General part"; } }

        public double Consumation { get { return DeviceConsumpent; } }
        public virtual double DeviceConsumpent { get; protected set; }
    }
}
