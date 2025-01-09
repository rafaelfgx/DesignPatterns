public sealed class ConcretePrototypeA(string name) : Prototype(name)
{
    public override Prototype Clone() => (Prototype)MemberwiseClone();
}
