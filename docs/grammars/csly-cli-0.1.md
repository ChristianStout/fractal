
genericLexer WhileTokenGeneric;

[KeyWord] LET : "let";
[KeyWord] MUT : "mut";
[KeyWord] PRINT : "print";
[KeyWord] IF : "if";
[KeyWord] ELSE : "else";
[KeyWord] WHILE : "while";

[KeyWord] TRUE : "true";

[KeyWord] FALSE : "false";

[AlphaId] IDENTIFIER;

[String] STRING;

[Int] INT;

[Sugar] NOT : "!";

[Sugar] AND : "&&";

[Sugar] OR : "||";

[Sugar] GREATER : ">";

[Sugar] LESSER : "<";

[Sugar] EQUALS : "==";

[Sugar] DIFFERENT : "!=";

[Sugar] CONCAT : ".";

[Sugar] ASSIGN : "=";

[Sugar] PLUS : "+";

[Sugar] MINUS : "-";

[Sugar] TIMES : "*";

[Sugar] DIVIDE : "/";

[Sugar] LPAREN : "(";

[Sugar] RPAREN : ")";

[Sugar] SEMICOLON : ";";

[Sugar] LCURLY : "{";

[Sugar] RCURLY : "}";

parser WhileParserGeneric;

[Right 50] LESSER;
[Right 50] GREATER;
[Right 50] EQUALS;
[Right 50] DIFFERENT;
[Right 10] CONCAT;
-> statement :  statementBlock ;
-> statement : sequence;
statementBlock:  LCURLY statement RCURLY ;
sequence : statementPrim additionalStatements*;
additionalStatements : SEMICOLON statementPrim;
additionalStatements : SEMICOLON;
statementPrim: expression;
statementPrim: IF expression statementBlock;
statementPrim: IF expression statementBlock ELSE statementBlock;
statementPrim: WHILE expression statementBlock;
expression: LET MUT? IDENTIFIER ASSIGN WhileParserGeneric_expressions;
expression: PRINT LPAREN WhileParserGeneric_expressions RPAREN;
expression: IDENTIFIER ASSIGN WhileParserGeneric_expressions;
expression: WhileParserGeneric_expressions;
primary: INT;
primary: TRUE;
primary: FALSE;
primary: STRING;
primary: IDENTIFIER;
[Operand] operand: primary;
[Right 10] PLUS;
[Right 10] MINUS;
[Right 50] TIMES;
[Right 50] DIVIDE;
[Prefix 100] MINUS;
[Right 10] OR;
[Right 50] AND;
[Prefix 100] NOT;
