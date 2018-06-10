namespace Observer_Pattern
{
    public interface ISubject
    {
        void RegisterObserver(IObserver observer);
        void DeleteObserver(IObserver observer);
        void NotifyObserver();
    }
}
