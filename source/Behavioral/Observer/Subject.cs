public abstract record Subject
{
    public List<Observer> Observers { get; } = [];

    public void Attach(Observer observer) => Observers.Add(observer);

    public void Detach(Observer observer) => Observers.Remove(observer);

    public void Notify() => Observers.ForEach(observer => observer.Update());
}
