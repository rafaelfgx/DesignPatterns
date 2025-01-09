public abstract class Prototype(string name)
{
    public string Name { get; } = name;

    public abstract Prototype Clone();
}
