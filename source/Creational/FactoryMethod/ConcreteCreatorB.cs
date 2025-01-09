public sealed record ConcreteCreatorB : Creator
{
    public override Product Create() => new ConcreteProductB();
}
