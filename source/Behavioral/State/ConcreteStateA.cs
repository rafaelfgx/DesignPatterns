public sealed record ConcreteStateA : State
{
    public override void Handle(Context context) => context.State = new ConcreteStateB();
}
