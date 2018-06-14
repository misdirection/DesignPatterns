using System;

namespace Observer_Pattern
{
    public interface IObserver
    {
        void Update(string Title, DateTime dateTime);
    }
}
