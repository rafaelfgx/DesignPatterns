public sealed record Context(Strategy Strategy)
{
    public void Handle() => Strategy.Handle();
}
