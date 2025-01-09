var mediator = new ConcreteMediator();

var concreteColleagueA = new ConcreteColleagueA(mediator);

var concreteColleagueB = new ConcreteColleagueB(mediator);

mediator.ColleagueA = concreteColleagueA;

mediator.ColleagueB = concreteColleagueB;

concreteColleagueA.Send("Message from ConcreteColleagueA");

concreteColleagueB.Send("Message from ConcreteColleagueB");

Console.ReadKey();
