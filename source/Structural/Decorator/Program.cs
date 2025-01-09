var component = new ConcreteComponent();

var concreteDecoratorA = new ConcreteDecoratorA();

var concreteDecoratorB = new ConcreteDecoratorB();

concreteDecoratorA.SetComponent(component);

concreteDecoratorB.SetComponent(concreteDecoratorA);

concreteDecoratorB.Method();

Console.ReadKey();
