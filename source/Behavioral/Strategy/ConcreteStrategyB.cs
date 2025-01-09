public sealed record ConcreteStrategyB : Strategy
{
    public override void Handle() => Console.WriteLine("ConcreteStrategyB.Handle()");
}
