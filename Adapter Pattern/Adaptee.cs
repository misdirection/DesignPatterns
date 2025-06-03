// Adaptee.cs
using System;

namespace AdapterPattern
{
    // The existing class with an incompatible interface
    public class Adaptee
    {
        public string GetSpecificRequest()
        {
            return "Specific request from Adaptee";
        }
    }
}
