public sealed record RefinedAbstraction : Abstraction
{
    public override void Method() => Implementor.Method();
}
