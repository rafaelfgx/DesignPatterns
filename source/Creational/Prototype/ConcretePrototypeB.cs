public sealed class ConcretePrototypeB(string name) : Prototype(name)
{
    public override Prototype Clone() => (Prototype)MemberwiseClone();
}
