public abstract record Iterator
{
    public abstract object CurrentItem();

    public abstract object First();

    public abstract bool IsDone();

    public abstract object Next();
}
