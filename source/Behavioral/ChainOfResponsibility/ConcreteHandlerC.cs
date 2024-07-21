public sealed record ConcreteHandlerC : Handler
{
    public override void Handle(object request)
    {
        Console.WriteLine($"ConcreteHandlerC.Handle()");

        Next?.Handle(request);
    }
}
