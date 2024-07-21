public sealed record Product
{
    public List<string> Parts { get; } = new();

    public void Add(string part) => Parts.Add(part);

    public void Show() => Parts.ForEach(Console.WriteLine);
}
