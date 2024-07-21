public sealed record ConcreteStrategyC : Strategy
{
    public override void Handle() => Console.WriteLine("ConcreteStrategyC.Handle()");
}
