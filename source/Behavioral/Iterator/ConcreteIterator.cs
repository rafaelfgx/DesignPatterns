public sealed record ConcreteIterator(ConcreteAggregate Aggregate) : Iterator
{
    public int Current { get; private set; }

    public override object CurrentItem() => Aggregate[Current];

    public override object First() => Aggregate[0];

    public override bool IsDone() => Current >= Aggregate.Count;

    public override object Next()
    {
        object result = default;

        if (Current < Aggregate.Count - 1)
        {
            result = Aggregate[++Current];
        }

        return result;
    }
}
