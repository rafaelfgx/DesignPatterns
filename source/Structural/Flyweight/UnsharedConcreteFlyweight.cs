public sealed record UnsharedConcreteFlyweight : Flyweight
{
    public override void Method(int extrinsicstate) => Console.WriteLine("UnsharedConcreteFlyweight.Method(): " + extrinsicstate);
}
