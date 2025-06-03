namespace Adapter_Pattern
{
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string Request()
        {
            return _adaptee.SpecificRequest();
        }
    }
}
