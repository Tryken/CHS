namespace Singleton
{
    public class ExampleSingleton : Singleton<ExampleSingleton>
    {
        public void execute()
        {
            Instance.Exists();
        }
    }
}