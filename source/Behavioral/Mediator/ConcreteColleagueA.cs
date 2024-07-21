public sealed record ConcreteColleagueA : Colleague
{
    public ConcreteColleagueA(Mediator mediator) : base(mediator) { }

    public void Notify(string message) => Console.WriteLine("ConcreteColleagueA gets message: " + message);

    public void Send(string message) => Mediator.Send(message, this);
}
