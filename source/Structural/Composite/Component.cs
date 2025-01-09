public abstract record Component
{
    protected readonly string Name;

    protected Component(string name) => Name = name;

    public abstract void Add(Component component);

    public abstract void Remove(Component component);

    public abstract void Show(int depth);
}
