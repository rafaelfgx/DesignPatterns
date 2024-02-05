var concreteSubject = new ConcreteSubject();

concreteSubject.Attach(new ConcreteObserver(concreteSubject, "ConcreteObserverA"));

concreteSubject.Attach(new ConcreteObserver(concreteSubject, "ConcreteObserverB"));

concreteSubject.Attach(new ConcreteObserver(concreteSubject, "ConcreteObserverC"));

concreteSubject.SubjectState = "State";

concreteSubject.Notify();

Console.ReadKey();
