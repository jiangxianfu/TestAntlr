using Antlr4.Runtime;
using System;
using TestAntlr.MySql;
using TestAntlr.SqlServer;

namespace TestAntlr
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("MySql");
            TestMySql();
            Console.WriteLine("SqlServer");
            TestSqlServer();
            Console.WriteLine("ok");
            Console.ReadLine();
        }
        static void TestMySql()
        {
            var sql = "SELECT a from t WHERE `id`='am' and m in ('aaa','ssss')";
            ICharStream charStream = CharStreams.fromString(sql);
            MySqlLexer lexer = new MySqlLexer(charStream);
            CommonTokenStream tokenSteam = new CommonTokenStream(lexer);
            var mysqlParser = new MySqlParser(tokenSteam);
            var data = mysqlParser.root();
            Console.WriteLine(data.ToStringTree(mysqlParser));
        }
        static void TestSqlServer()
        {
            var sql = "SELECT a from d..t WHERE id='am' and m in ('aaa','ssss')";
            ICharStream charStream = CharStreams.fromString(sql);
            TSqlLexer lexer = new TSqlLexer(charStream);
            CommonTokenStream tokenSteam = new CommonTokenStream(lexer);
            var sqlParser = new TSqlParser(tokenSteam);
            var data = sqlParser.tsql_file();
            Console.WriteLine(data.ToStringTree(sqlParser));
        }
    }
}
