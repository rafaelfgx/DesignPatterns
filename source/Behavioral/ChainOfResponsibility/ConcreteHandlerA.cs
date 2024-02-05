public sealed record ConcreteHandlerA : Handler
{
    public override void Handle(object request)
    {
        Console.WriteLine($"ConcreteHandlerA.Handle()");

        Next?.Handle(request);
    }
}
