using System.Collections.Generic;

namespace Abstract_Factory_Pattern
{
    public class YStore : AbstractStore
    {
        protected override Device BuildDevice(DeviceType deviceType)
        {
            Device orderedDevice = null;

            switch (deviceType)
            {
                case DeviceType.Computer:
                    orderedDevice = new Computer(new PineappleFactory());
                    orderedDevice.Name = "YMac";
                    break;
                case DeviceType.Smartphone:
                    orderedDevice = new Smartphone(new PineappleFactory());
                    orderedDevice.Name = "YPhone";
                    break;
                case DeviceType.Tablet:
                    orderedDevice = new Tablet(new PineappleFactory());
                    orderedDevice.Name = "YPad";
                    break;
                default:
                    System.Console.WriteLine("Not a valid device!");
                    break;
            }
            return orderedDevice;
        }
    }
}
