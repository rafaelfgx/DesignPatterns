using System.Collections;

public sealed record FlyweightFactory
{
    public FlyweightFactory()
    {
        Flyweights.Add("ConcreteFlyweightA", new ConcreteFlyweight());

        Flyweights.Add("ConcreteFlyweightB", new ConcreteFlyweight());

        Flyweights.Add("ConcreteFlyweightC", new ConcreteFlyweight());
    }

    private Hashtable Flyweights { get; } = new();

    public Flyweight GetFlyweight(string key) => (Flyweight)Flyweights[key];
}
