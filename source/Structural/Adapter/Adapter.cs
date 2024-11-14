public sealed record Adapter : ITarget
{
    public void Method() => new Adaptee().Method();
}
