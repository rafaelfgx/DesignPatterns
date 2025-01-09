var concreteAggregate = new ConcreteAggregate
{
    [0] = "Item A",
    [1] = "Item B",
    [2] = "Item C",
    [3] = "Item D"
};

var iterator = concreteAggregate.CreateIterator();

Console.WriteLine("Iterating:");

var item = iterator.First();

while (item != null)
{
    Console.WriteLine(item);
    item = iterator.Next();
}

Console.ReadKey();
