public abstract record Abstraction
{
    public Implementor Implementor { get; set; }

    public virtual void Method() => Implementor.Method();
}
