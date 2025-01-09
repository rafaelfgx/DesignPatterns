using System.Collections;

public sealed record ConcreteAggregate : Aggregate
{
    public int Count => Items.Count;

    public ArrayList Items { get; } = new();

    public object this[int index]
    {
        get => Items[index];
        set => Items.Insert(index, value);
    }

    public override Iterator CreateIterator() => new ConcreteIterator(this);
}
