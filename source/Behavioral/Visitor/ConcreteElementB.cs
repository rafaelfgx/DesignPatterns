public sealed record ConcreteElementB : Element
{
    public override void Accept(Visitor visitor) => visitor.VisitConcreteElementB(this);

    public void OperationB() => Console.WriteLine("ConcreteElementB.OperationB()");
}
