var concretePrototypeA1 = new ConcretePrototypeA("ConcretePrototypeA");

var concretePrototypeA2 = (ConcretePrototypeA)concretePrototypeA1.Clone();

Console.WriteLine($"Clone: {concretePrototypeA2.Name}");

var concretePrototypeB1 = new ConcretePrototypeB("ConcretePrototypeB");

var concretePrototypeB2 = (ConcretePrototypeB)concretePrototypeB1.Clone();

Console.WriteLine($"Clone: {concretePrototypeB2.Name}");

Console.ReadKey();
