public sealed record Context(State State)
{
    public State State { get; set; } = State;

    public void Request() => State.Handle(this);
}
