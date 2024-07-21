public sealed record NonTerminalExpression : AbstractExpression
{
    public override void Interpret(Context context) => Console.WriteLine("NonTerminalExpression.Interpret()");
}
