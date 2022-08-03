using MoonSharp.Interpreter.Interop;

namespace Singleton
{
    public abstract class Singleton <T>  where T : Singleton<T>, new()
    {
        private static T _mInstance;
        
        [MoonSharpVisible(false)]
        public static T Instance => _mInstance ??= new T();

        [MoonSharpVisible(false)]
        public bool Exists()
        {
            return (_mInstance != null);
        }
    }
}