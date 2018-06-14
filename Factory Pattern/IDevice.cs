namespace Factory_Method_Pattern
{
    public interface IDevice
    {
        string Name { get; }
    }
    public enum DeviceType
    {
        PC,
        Smartphone
    }

}
