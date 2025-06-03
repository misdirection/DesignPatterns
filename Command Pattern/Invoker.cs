// Invoker.cs
using System;
using System.Collections.Generic;

namespace CommandPattern
{
    // Asks the command to carry out the request
    public class Invoker
    {
        private ICommand? _onStart;
        private ICommand? _onFinish;

        private List<ICommand> commandHistory = new List<ICommand>();

        public void SetOnStart(ICommand command)
        {
            _onStart = command;
        }

        public void SetOnFinish(ICommand command)
        {
            _onFinish = command;
        }

        // The Invoker can execute commands immediately or store them
        public void DoSomethingImportant()
        {
            Console.WriteLine("Invoker: Does anybody want something done before I begin?");
            _onStart?.Execute();
            // Store command in history for potential undo
            if (_onStart != null) commandHistory.Add(_onStart);


            Console.WriteLine("Invoker: ...doing something really important...");

            Console.WriteLine("Invoker: Does anybody want something done after I finish?");
            _onFinish?.Execute();
            if (_onFinish != null) commandHistory.Add(_onFinish);
        }

        public void UndoLastCommand()
        {
            if (commandHistory.Count > 0)
            {
                ICommand lastCommand = commandHistory[commandHistory.Count - 1];
                lastCommand.Undo();
                commandHistory.RemoveAt(commandHistory.Count - 1);
            }
            else
            {
                Console.WriteLine("Invoker: No commands to undo.");
            }
        }
    }
}
