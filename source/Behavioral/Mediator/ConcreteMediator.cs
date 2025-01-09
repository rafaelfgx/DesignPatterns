public sealed record ConcreteMediator : Mediator
{
    public ConcreteColleagueA ColleagueA { get; set; }

    public ConcreteColleagueB ColleagueB { get; set; }

    public override void Send(string message, Colleague colleague)
    {
        if (colleague == ColleagueA)
        {
            ColleagueB.Notify(message);
        }
        else
        {
            ColleagueA.Notify(message);
        }
    }
}
