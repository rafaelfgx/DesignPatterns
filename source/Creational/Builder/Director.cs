public sealed record Director
{
    public void Construct(Builder builder)
    {
        builder.BuildPart1();

        builder.BuildPart2();
    }
}
