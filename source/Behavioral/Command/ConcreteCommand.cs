public sealed record ConcreteCommand : Command
{
    public ConcreteCommand(Receiver receiver) : base(receiver) { }

    public override void Execute() => Receiver.Action();
}
