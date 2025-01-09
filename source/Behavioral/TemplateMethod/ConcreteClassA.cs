public sealed record ConcreteClassA : AbstractClass
{
    protected override void PrimitiveOperation1() => Console.WriteLine("ConcreteClassA.PrimitiveOperation1()");

    protected override void PrimitiveOperation2() => Console.WriteLine("ConcreteClassA.PrimitiveOperation2()");
}
