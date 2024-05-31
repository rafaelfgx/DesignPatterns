public sealed record Singleton
{
    private static readonly object InstanceLock = new();

    private static Singleton _instance;

    private Singleton() { }

    public static Singleton Instance
    {
        get
        {
            if (_instance is not null) return _instance;

            lock (InstanceLock)
            {
                _instance ??= new Singleton();
            }

            return _instance;
        }
    }
}
