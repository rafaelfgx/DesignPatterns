public sealed record ConcreteComponent : Component
{
    public override void Method() => Console.WriteLine("ConcreteComponent.Method()");
}
