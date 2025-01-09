public sealed record ConcreteClassB : AbstractClass
{
    protected override void PrimitiveOperation1() => Console.WriteLine("ConcreteClassB.PrimitiveOperation1()");

    protected override void PrimitiveOperation2() => Console.WriteLine("ConcreteClassB.PrimitiveOperation2()");
}
