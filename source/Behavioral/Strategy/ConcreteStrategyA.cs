public sealed record ConcreteStrategyA : Strategy
{
    public override void Handle() => Console.WriteLine("ConcreteStrategyA.Handle()");
}
