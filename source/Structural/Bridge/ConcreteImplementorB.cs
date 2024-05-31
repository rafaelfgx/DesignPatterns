public sealed record ConcreteImplementorB : Implementor
{
    public override void Method() => Console.WriteLine("ConcreteImplementorB.Method()");
}
