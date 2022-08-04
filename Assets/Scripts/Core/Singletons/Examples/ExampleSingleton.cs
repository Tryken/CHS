namespace Core.Singletons.Examples
{
    public class ExampleSingleton : Singleton<ExampleSingleton>
    {
        public void execute()
        {
            Instance.Exists();
        }
    }
}