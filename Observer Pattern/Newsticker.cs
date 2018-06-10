using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Observer_Pattern
{
    public class Newsticker : ISubject
    {
        private List<IObserver> _observers;

        public Newsticker() => _observers = new List<IObserver>();
        public string Title { get; set; }
        public DateTime Date { get; set; }

        public void DeleteObserver(IObserver observer) => _observers.Remove(observer);
        public void NotifyObserver()
        {
            foreach(var observer in _observers)
            {
                observer.Update(Title, Date);
            }
        }
        public void RegisterObserver(IObserver observer) => _observers.Add(observer);
        public void PropertiesChanged() => NotifyObserver();
        public void SetNews(string title)
        {
            Title = title;
            Date = DateTime.Now;
            PropertiesChanged();
        }
    }
}
