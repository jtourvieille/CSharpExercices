using System.Dynamic;

namespace CS.Impl._04_Advanced
{
    public class Singleton
    {
        private static Singleton _instance;

        private Singleton()
        {
            
        }

        public static Singleton Instance
        {
            get
            {
                if (_instance == null)
                {
                    _instance = new Singleton();
                }

                return _instance;
            }
        }
    }

    public interface IMySingleton { }
    public class MySingleton : IMySingleton { }
}
