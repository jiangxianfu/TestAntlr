using Antlr4.Runtime.Tree;
using System;
using System.Collections.Generic;
using System.Text;
using TestAntlr.Parser;
using static TestAntlr.Parser.MySqlParser;

namespace TestAntlr
{
   public class MyVisitor: MySqlParserBaseVisitor<SelectStatementContext>
    {
        public override SelectStatementContext Visit(IParseTree tree)
        {
            return base.Visit(tree);
        }
    }
}
