var originator = new Originator { State = "ON" };

Console.WriteLine("State is " + originator.State);

var caretaker = new Caretaker { Memento = originator.CreateMemento() };

originator.State = "OFF";

Console.WriteLine("State is " + originator.State);

Console.WriteLine("Restoring state...");

originator.SetMemento(caretaker.Memento);

Console.WriteLine("State is " + originator.State);

Console.ReadKey();
