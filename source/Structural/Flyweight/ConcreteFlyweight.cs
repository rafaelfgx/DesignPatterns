public sealed record ConcreteFlyweight : Flyweight
{
    public override void Method(int extrinsicstate) => Console.WriteLine("ConcreteFlyweight.Method(): " + extrinsicstate);
}
