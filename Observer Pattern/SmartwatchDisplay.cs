using System;

namespace Observer_Pattern
{
    public class SmartwatchDisplay : IObserver, IDisplay
    {
        private ISubject _subject;
        private string _title;
        private DateTime _date;
        public SmartwatchDisplay(ISubject subject)
        {
            _subject = subject;
        }

        public void Update(string title, DateTime dateTime)
        {
            _title = title;
            _date = dateTime;
            Display();
        }
        public void Display()
        {
            Console.WriteLine("News of the day. Title: " + _title + " Date: " + _date);
        }
    }
}
