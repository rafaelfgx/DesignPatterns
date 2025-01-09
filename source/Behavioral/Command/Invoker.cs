public sealed record Invoker
{
    private Command Command { get; set; }

    public void ExecuteCommand() => Command?.Execute();

    public void SetCommand(Command command) => Command = command;
}
