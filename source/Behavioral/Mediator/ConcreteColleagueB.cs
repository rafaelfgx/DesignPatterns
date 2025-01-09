public sealed record ConcreteColleagueB : Colleague
{
    public ConcreteColleagueB(Mediator mediator) : base(mediator) { }

    public void Notify(string message) => Console.WriteLine("ConcreteColleagueB gets message: " + message);

    public void Send(string message) => Mediator.Send(message, this);
}
