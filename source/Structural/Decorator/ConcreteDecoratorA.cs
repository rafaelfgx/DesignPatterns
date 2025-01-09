public sealed record ConcreteDecoratorA : Decorator
{
    public override void Method()
    {
        base.Method();

        Console.WriteLine("ConcreteDecoratorA.Method()");
    }
}
