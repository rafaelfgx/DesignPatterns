public sealed record ConcreteCreatorA : Creator
{
    public override Product Create() => new ConcreteProductA();
}
