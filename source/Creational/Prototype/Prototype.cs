public abstract class Prototype
{
    protected Prototype(string name) => Name = name;

    public string Name { get; }

    public abstract Prototype Clone();
}
