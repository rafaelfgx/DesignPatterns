public abstract record Handler
{
    protected Handler Next;

    public abstract void Handle(object request);

    public void SetNext(Handler next) => Next = next;
}
