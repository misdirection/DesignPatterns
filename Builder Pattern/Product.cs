// Product.cs
using System;
using System.Collections.Generic;

namespace BuilderPattern
{
    // The complex object
    public class Product
    {
        private List<string> parts = new List<string>();

        public void AddPart(string part)
        {
            parts.Add(part);
        }

        public void ShowParts()
        {
            Console.WriteLine("\nProduct Parts-------");
            foreach (string part in parts)
            {
                Console.WriteLine(part);
            }
            Console.WriteLine("--------------------");
        }
    }
}
