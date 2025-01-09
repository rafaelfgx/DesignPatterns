var abstraction = new RefinedAbstraction { Implementor = new ConcreteImplementorA() };

abstraction.Method();

abstraction.Implementor = new ConcreteImplementorB();

abstraction.Method();

Console.ReadKey();
