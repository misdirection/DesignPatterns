// ConcreteCommand.cs
using System;

namespace CommandPattern
{
    public class ConcreteCommand : ICommand
    {
        private Receiver _receiver;
        private string _payload; // Data needed to execute the command

        public ConcreteCommand(Receiver receiver, string payload)
        {
            _receiver = receiver;
            _payload = payload;
        }

        public void Execute()
        {
            _receiver.PerformAction(_payload);
        }

        public void Undo()
        {
            _receiver.PerformUndoAction(_payload);
        }
    }
}
