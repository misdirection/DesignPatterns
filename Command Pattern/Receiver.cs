// Receiver.cs
using System;

namespace CommandPattern
{
    // Contains the business logic / actual work to be done
    public class Receiver
    {
        public void PerformAction(string action)
        {
            Console.WriteLine($"Receiver: Performing action - {action}");
        }

        public void PerformUndoAction(string action)
        {
            Console.WriteLine($"Receiver: Undoing action - {action}");
        }
    }
}
