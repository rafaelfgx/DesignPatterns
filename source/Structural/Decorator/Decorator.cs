public abstract record Decorator : Component
{
    public Component Component { get; private set; }

    public override void Method() => Component?.Method();

    public void SetComponent(Component component) => Component = component;
}
