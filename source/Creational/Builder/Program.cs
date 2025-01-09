var director = new Director();

var builderA = new ConcreteBuilderA();

var builderB = new ConcreteBuilderB();

director.Construct(builderA);

var productA = builderA.GetResult();

Console.WriteLine("Product A");

productA.Show();

Console.WriteLine();

director.Construct(builderB);

var productB = builderB.GetResult();

Console.WriteLine("Product B");

productB.Show();

Console.ReadKey();
