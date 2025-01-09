public abstract record State
{
    public abstract void Handle(Context context);
}
