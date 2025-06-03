// Adapter.cs
namespace AdapterPattern
{
    // The Adapter class makes the Adaptee's interface compatible with the Target's interface.
    public class Adapter : ITarget
    {
        private readonly Adaptee _adaptee;

        public Adapter(Adaptee adaptee)
        {
            _adaptee = adaptee;
        }

        public string GetRequest()
        {
            // Translate the ITarget call to an Adaptee call
            return $"This is '{_adaptee.GetSpecificRequest()}' - translated by Adapter";
        }
    }
}
