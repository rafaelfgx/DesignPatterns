public sealed record Originator
{
    public string State { get; set; }

    public Memento CreateMemento() => new(State);

    public void SetMemento(Memento memento) => State = memento.State;
}
