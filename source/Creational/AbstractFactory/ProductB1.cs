public sealed record ProductB1 : AbstractProductB
{
    public override void Interact(AbstractProductA abstractProductA) => Console.WriteLine(GetType().Name + " interacts with " + abstractProductA.GetType().Name);
}
