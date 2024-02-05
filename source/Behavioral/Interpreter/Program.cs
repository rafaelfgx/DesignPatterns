using System.Collections;

var context = new Context();

var expressions = new ArrayList
{
    new TerminalExpression(),
    new NonTerminalExpression(),
    new TerminalExpression(),
    new TerminalExpression(),
    new NonTerminalExpression()
};

foreach (AbstractExpression expression in expressions)
{
    expression.Interpret(context);
}

Console.ReadKey();
