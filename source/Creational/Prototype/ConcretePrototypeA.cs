public sealed class ConcretePrototypeA : Prototype
{
    public ConcretePrototypeA(string name) : base(name) { }

    public override Prototype Clone() => (Prototype)MemberwiseClone();
}
