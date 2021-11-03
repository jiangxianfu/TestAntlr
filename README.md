# Test Antlr
### 生成代码
java -jar c:/antlr-4.9.2-complete.jar -Dlanguage=CSharp -package TestAntlr.Parser -no-listener -visitor -o ./Parser MySqlLexer.g4 MySqlParser.g4