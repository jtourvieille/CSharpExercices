using System;

namespace CS.Impl._04_Advanced
{
    public class Singleton
    {
        public static Singleton Instance => throw new NotImplementedException();
    }

    public interface IMySingleton { }
    public class MySingleton : IMySingleton { }
}