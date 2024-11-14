public sealed record Proxy : Subject
{
    public override void Method() => new RealSubject().Method();
}
