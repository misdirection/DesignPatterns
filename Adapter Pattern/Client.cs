// Client.cs
using System;

namespace AdapterPattern
{
    public class Client
    {
        public void MakeRequest(ITarget target)
        {
            Console.WriteLine(target.GetRequest());
        }
    }
}
