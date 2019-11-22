using System;
using System.Collections.Generic;
using System.Text;

namespace Robotic
{
    class RoboticChasis : RoboticPart
    {
        public RoboticChasis(string name, double battery, double consumption)
        {
            Name = name;
            MaxBattery = battery;
            DeviceConsumption = consumption;
            RemainingBatteryCapacity = MaxBattery;
        }
    public string Name { get; protected set; }
    public double MaxBattery { get; protected set; }
    public double RemainingBatteryCapacity { get; protected set; }
    public double DeviceConsumption { get; protected set; }
    }
}
