public sealed record Composite : Component
{
    public Composite(string name) : base(name) { }

    public List<Component> Children { get; } = new();

    public override void Add(Component component) => Children.Add(component);

    public override void Remove(Component component) => Children.Remove(component);

    public override void Show(int depth)
    {
        Console.WriteLine(new string('-', depth) + Name);

        foreach (var component in Children)
        {
            component.Show(depth + 4);
        }
    }
}
