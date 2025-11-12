using sly.lexer;
using sly.parser.generator;
using System.Collections.Generic;
using sly.parser.parser;


namespace src.parser
{
    [ParserRoot("statement")]
    public class FractalParser
    {
        [Infix("LESSER", Associativity.Right, 50)]
        public object LESSER(object left, Token<FractalToken> oper, object right)
        {
            return left;
        }

        [Infix("GREATER", Associativity.Right, 50)]
        public object GREATER(object left, Token<FractalToken> oper, object right)
        {
            return left;
        }

        [Infix("EQUALS", Associativity.Right, 50)]
        public object EQUALS(object left, Token<FractalToken> oper, object right)
        {
            return left;
        }

        [Infix("DIFFERENT", Associativity.Right, 50)]
        public object DIFFERENT(object left, Token<FractalToken> oper, object right)
        {
            return left;
        }

        [Infix("CONCAT", Associativity.Right, 10)]
        public object CONCAT(object left, Token<FractalToken> oper, object right)
        {
            return left;
        }

        [Production("statement : statementBlock")]
        public object statement_statementBlock(object p0)
        {
            return default(object);
        }

        [Production("statement : sequence")]
        public object statement_sequence(object p0)
        {
            return default(object);
        }

        [Production("statementBlock : LCURLY statement RCURLY")]
        public object statementBlock_LCURLY_statement_RCURLY(Token<FractalToken> p0, object p1, Token<FractalToken> p2)
        {
            return default(object);
        }

        [Production("sequence : statementPrim additionalStatements *")]
        public object sequence_statementPrim_additionalStatements_(object p0, List<object> p1)
        {
            return default(object);
        }

        [Production("additionalStatements : SEMICOLON statementPrim")]
        public object additionalStatements_SEMICOLON_statementPrim(Token<FractalToken> p0, object p1)
        {
            return default(object);
        }

        [Production("additionalStatements : SEMICOLON")]
        public object additionalStatements_SEMICOLON(Token<FractalToken> p0)
        {
            return default(object);
        }

        [Production("statementPrim : expression")]
        public object statementPrim_expression(object p0)
        {
            return default(object);
        }

        [Production("statementPrim : IF expression statementBlock")]
        public object statementPrim_IF_expression_statementBlock(Token<FractalToken> p0, object p1, object p2)
        {
            return default(object);
        }

        [Production("statementPrim : IF expression statementBlock ELSE statementBlock")]
        public object statementPrim_IF_expression_statementBlock_ELSE_statementBlock(Token<FractalToken> p0, object p1, object p2, Token<FractalToken> p3, object p4)
        {
            return default(object);
        }

        [Production("statementPrim : WHILE expression statementBlock")]
        public object statementPrim_WHILE_expression_statementBlock(Token<FractalToken> p0, object p1, object p2)
        {
            return default(object);
        }

        [Production("expression : LET MUT? IDENTIFIER ASSIGN WhileParserGeneric_expressions")]
        public object expression_LET_MUT_IDENTIFIER_ASSIGN_WhileParserGenericexpressions(Token<FractalToken> p0, Token<FractalToken> p1, Token<FractalToken> p2, Token<FractalToken> p3, object p4)
        {
            return default(object);
        }

        [Production("expression : PRINT LPAREN WhileParserGeneric_expressions RPAREN")]
        public object expression_PRINT_LPAREN_WhileParserGenericexpressions_RPAREN(Token<FractalToken> p0, Token<FractalToken> p1, object p2, Token<FractalToken> p3)
        {
            return default(object);
        }

        [Production("expression : IDENTIFIER ASSIGN WhileParserGeneric_expressions")]
        public object expression_IDENTIFIER_ASSIGN_WhileParserGenericexpressions(Token<FractalToken> p0, Token<FractalToken> p1, object p2)
        {
            return default(object);
        }

        [Production("expression : WhileParserGeneric_expressions")]
        public object expression_WhileParserGenericexpressions(object p0)
        {
            return default(object);
        }

        [Production("primary : INT")]
        public object primary_INT(Token<FractalToken> p0)
        {
            return default(object);
        }

        [Production("primary : TRUE")]
        public object primary_TRUE(Token<FractalToken> p0)
        {
            return default(object);
        }

        [Production("primary : FALSE")]
        public object primary_FALSE(Token<FractalToken> p0)
        {
            return default(object);
        }

        [Production("primary : STRING")]
        public object primary_STRING(Token<FractalToken> p0)
        {
            return default(object);
        }

        [Production("primary : IDENTIFIER")]
        public object primary_IDENTIFIER(Token<FractalToken> p0)
        {
            return default(object);
        }

        [Operand]
        [Production("operand : primary")]
        public object operand_primary(object p0)
        {
            return default(object);
        }

        [Infix("PLUS", Associativity.Right, 10)]
        public object PLUS(object left, Token<FractalToken> oper, object right)
        {
            return left;
        }

        [Infix("MINUS", Associativity.Right, 10)]
        public object MINUS(object left, Token<FractalToken> oper, object right)
        {
            return left;
        }

        [Infix("TIMES", Associativity.Right, 50)]
        public object TIMES(object left, Token<FractalToken> oper, object right)
        {
            return left;
        }

        [Infix("DIVIDE", Associativity.Right, 50)]
        public object DIVIDE(object left, Token<FractalToken> oper, object right)
        {
            return left;
        }

        [Prefix("MINUS", Associativity.Left, 100)]
        public object MINUS(Token<FractalToken> oper, object value)
        {
            return value;
        }

        [Infix("OR", Associativity.Right, 10)]
        public object OR(object left, Token<FractalToken> oper, object right)
        {
            return left;
        }

        [Infix("AND", Associativity.Right, 50)]
        public object AND(object left, Token<FractalToken> oper, object right)
        {
            return left;
        }

        [Prefix("NOT", Associativity.Left, 100)]
        public object NOT(Token<FractalToken> oper, object value)
        {
            return value;
        }
    }
}