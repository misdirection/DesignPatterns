using System;

namespace Factory_Method_Pattern
{
    public class DeviceFactory
    {
        public IDevice MakeDevice(DeviceType deviceType)
        {
            switch (deviceType)
            {
                case DeviceType.PC:
                    return new PC();
                case DeviceType.Smartphone:
                    return new Smartphone();
                default:
                    throw new NotSupportedException();
            }
        }
    }
}
