public sealed record ObjectStructure
{
    public List<Element> Elements { get; } = new();

    public void Accept(Visitor visitor) => Elements.ForEach(element => element.Accept(visitor));

    public void Attach(Element element) => Elements.Add(element);

    public void Detach(Element element) => Elements.Remove(element);
}
