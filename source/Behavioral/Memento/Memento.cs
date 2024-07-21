public sealed record Memento
{
    public Memento(string state) => State = state;

    public string State { get; }
}
