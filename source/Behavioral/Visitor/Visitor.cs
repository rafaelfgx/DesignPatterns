public abstract record Visitor
{
    public abstract void VisitConcreteElementA(ConcreteElementA concreteElementA);

    public abstract void VisitConcreteElementB(ConcreteElementB concreteElementB);
}
