public abstract record Element
{
    public abstract void Accept(Visitor visitor);
}
