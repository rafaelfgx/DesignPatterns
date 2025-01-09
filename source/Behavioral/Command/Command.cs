public abstract record Command
{
    protected readonly Receiver Receiver;

    protected Command(Receiver receiver) => Receiver = receiver;

    public abstract void Execute();
}
