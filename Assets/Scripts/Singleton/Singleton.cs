namespace Singleton
{
    public abstract class Singleton <T>  where T : Singleton<T>, new()
    {
        private static T _mInstance;
        
        protected static T Instance => _mInstance ??= new T();

        protected bool Exists()
        {
            return (_mInstance != null);
        }
    }
}