public sealed record Context
{
    public Context(Strategy strategy) => Strategy = strategy;

    public Strategy Strategy { get; }

    public void Handle() => Strategy.Handle();
}
