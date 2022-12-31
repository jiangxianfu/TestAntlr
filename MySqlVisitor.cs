using Antlr4.Runtime.Tree;
using TestAntlr.MySql;
using static TestAntlr.MySql.MySqlParser;

namespace TestAntlr
{
    public class MySqlVisitor : MySqlParserBaseVisitor<SelectStatementContext>
    {
        public override SelectStatementContext Visit(IParseTree tree)
        {
            return base.Visit(tree);
        }
    }
}
