public abstract record AbstractClass
{
    public void TemplateMethod()
    {
        PrimitiveOperation1();
        PrimitiveOperation2();
    }

    protected abstract void PrimitiveOperation1();

    protected abstract void PrimitiveOperation2();
}
