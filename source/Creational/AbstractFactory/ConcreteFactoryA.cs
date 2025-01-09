public sealed record ConcreteFactoryA : AbstractFactory
{
    public override AbstractProductA CreateProductA() => new ProductA1();

    public override AbstractProductB CreateProductB() => new ProductB1();
}
