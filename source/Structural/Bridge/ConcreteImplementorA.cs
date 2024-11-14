public sealed record ConcreteImplementorA : Implementor
{
    public override void Method() => Console.WriteLine("ConcreteImplementorA.Method()");
}
