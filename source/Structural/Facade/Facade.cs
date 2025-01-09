public sealed record Facade
{
    public void Method1() => new SystemA().Method();

    public void Method2() => new SystemB().Method();
}
