var concreteHandlerA = new ConcreteHandlerA();

var concreteHandlerB = new ConcreteHandlerB();

var concreteHandlerC = new ConcreteHandlerC();

concreteHandlerA.SetNext(concreteHandlerB);

concreteHandlerB.SetNext(concreteHandlerC);

concreteHandlerA.Handle("Request");

Console.ReadKey();
