using Antlr4.Runtime;
using System;
using TestAntlr.Parser;

namespace TestAntlr
{
    class Program
    {
        static void Main(string[] args)
        {
            var sql = "SELECT a from t WHERE `id`='am' and m in ('aaa','ssss')";


            //ICharStream charStream = CharStreams.fromString(sql);
            //var lexer1 = new SQLiteLexer(charStream);
            //ITokenStream stream = new CommonTokenStream(lexer1);
            //SQLiteParser parser = new SQLiteParser(stream);
            //parser.BuildParseTree = true;
            //ParseContext tree = parser.parse();
            //var lines = tree.sql_stmt_list();
            ICharStream charStream= CharStreams.fromString(sql);
            MySqlLexer lexer = new MySqlLexer(charStream);
            CommonTokenStream tokenSteam = new CommonTokenStream(lexer);
            var mysqlParser = new MySqlParser(tokenSteam);
            var data = mysqlParser.root();

            Console.WriteLine(data.ToStringTree(mysqlParser));
            Console.WriteLine("ok");
            Console.WriteLine("Hello World!");
        }
    }
}
