public abstract record Colleague
{
    protected Mediator Mediator;

    protected Colleague(Mediator mediator) => Mediator = mediator;
}
