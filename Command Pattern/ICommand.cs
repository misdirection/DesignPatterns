// ICommand.cs
namespace CommandPattern
{
    public interface ICommand
    {
        void Execute();
        void Undo(); // Optional: for undoable commands
    }
}
