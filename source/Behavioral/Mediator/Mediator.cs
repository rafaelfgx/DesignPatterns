public abstract record Mediator
{
    public abstract void Send(string message, Colleague colleague);
}
