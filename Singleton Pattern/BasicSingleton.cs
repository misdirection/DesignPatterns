namespace Singleton_Pattern
{
    public class BasicSingleton
    {
        public string Text { get; set; }

        private static BasicSingleton _createInstance = null;
        private BasicSingleton()
        {
            Text = "I AM SINGLETON!";
        }
        public static BasicSingleton CreateInstance
        {
            get
            {
                if (_createInstance == null)
                {
                    _createInstance = new BasicSingleton();
                }
                return _createInstance;
            }
        }
    }
}
