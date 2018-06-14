using System;

namespace Abstract_Factory_Pattern
{
    public abstract class AbstractStore
    {
        protected abstract Device BuildDevice(DeviceType deviceType);
        public Device OrderDevice(DeviceType deviceType)
        {
            Console.WriteLine("Ordering device...");
            Device orderedDevice = BuildDevice(deviceType);
            orderedDevice.Assemble();
            Console.WriteLine("Shipping " + orderedDevice.Name + "...");
            return orderedDevice;
        }
    }
}
