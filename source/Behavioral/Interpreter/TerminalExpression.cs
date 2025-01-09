public sealed record TerminalExpression : AbstractExpression
{
    public override void Interpret(Context context) => Console.WriteLine("TerminalExpression.Interpret()");
}
