var extrinsicstate = 100;

var flyweightFactory = new FlyweightFactory();

flyweightFactory.GetFlyweight("ConcreteFlyweightA").Method(--extrinsicstate);

flyweightFactory.GetFlyweight("ConcreteFlyweightB").Method(--extrinsicstate);

flyweightFactory.GetFlyweight("ConcreteFlyweightC").Method(--extrinsicstate);

new UnsharedConcreteFlyweight().Method(--extrinsicstate);

Console.ReadKey();
