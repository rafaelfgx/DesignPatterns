public sealed record ConcreteHandlerB : Handler
{
    public override void Handle(object request)
    {
        Console.WriteLine($"ConcreteHandlerB.Handle()");

        Next?.Handle(request);
    }
}
