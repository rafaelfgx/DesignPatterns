public sealed record ConcreteDecoratorB : Decorator
{
    public override void Method()
    {
        base.Method();

        AddedBehavior();

        Console.WriteLine("ConcreteDecoratorB.Method()");
    }

    private static void AddedBehavior() => Console.WriteLine("ConcreteDecoratorB.AddedBehavior()");
}
