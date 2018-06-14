namespace Abstract_Factory_Pattern
{
    public enum DeviceType
    {
        Computer,
        Tablet,
        Smartphone
    }
    public abstract class Device
    {
        public string Name { get; set; }
        public ICPU Cpu { get; set; }
        public IGPU Gpu { get; set; }
        public IMotherboard Motherboard { get; set; }

        public abstract void Assemble();
    }
}