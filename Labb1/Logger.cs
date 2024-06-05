namespace Labb1
{
    //Logger Singleton
    internal class Logger
    {
        private static volatile Logger instance;
        private static readonly object lockObject = new object();
        private Logger() { }
        public static Logger Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (lockObject)
                    {
                        if (instance == null)
                        {
                            instance = new Logger();
                        }
                    }
                }
                return instance;
            }
        }
        public void Log(string message)
        {
            Console.WriteLine($"Log - [{DateTime.Now}]: {message}");
        }
    }
}
