var creators = new Creator[] { new ConcreteCreatorA(), new ConcreteCreatorB() };

foreach (var creator in creators)
{
    Console.WriteLine(creator.Create());
}

Console.ReadKey();
