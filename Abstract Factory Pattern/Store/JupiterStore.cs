using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Factory_Pattern
{
    public class JupiterStore : AbstractStore
    {
        protected override Device BuildDevice(DeviceType deviceType)
        {
            Device orderedDevice = null;

            switch (deviceType)
            {
                case DeviceType.Computer:
                    orderedDevice = new Computer(new PineappleFactory());
                    orderedDevice.Name = "DoorComputer";
                    break;
                case DeviceType.Smartphone:
                    orderedDevice = new Smartphone(new PineappleFactory());
                    orderedDevice.Name = "DoorPhone";
                    break;
                case DeviceType.Tablet:
                    orderedDevice = new Tablet(new PineappleFactory());
                    orderedDevice.Name = "DoorPad";
                    break;
                default:
                    System.Console.WriteLine("Not a valid device!");
                    break;
            }
            return orderedDevice;
        }
    }
}
