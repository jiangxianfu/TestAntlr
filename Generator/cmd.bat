echo 'generate mysql ...'
java -Xmx1024m -jar antlr-4.11.1-complete.jar -Dlanguage=CSharp -no-listener -visitor -o ../MySql -package TestAntlr.MySql MySqlLexer.g4 MySqlParser.g4
echo 'generate sqlserver ...'
java -Xmx1024m -jar antlr-4.11.1-complete.jar -Dlanguage=CSharp -no-listener -visitor -o ../SqlServer -package TestAntlr.SqlServer TSqlLexer.g4 TSqlParser.g4
echo 'finish'