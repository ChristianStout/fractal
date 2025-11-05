using sly.lexer;
using sly.parser.generator;
using System.Collections.Generic;
using sly.parser.parser;
using System.Reflection.Metadata.Ecma335;
using fractal.src.ast;

namespace fractal.src
{
    public class FractalParser
    {

        [Production("root: expression SEMICOLON")]
        public Node Root(Node node, Token<FractalToken> semicolon)
        {
            return new RootNode([]);
        }

        [Production("expression: INT")]
        public NumNode intExpr(Token<FractalToken> intToken)
        {
            return new NumNode(intToken);
        }


        [Production("expression: term MINUS expression")]
        [Production("expression: term PLUS expression")]
        public BinaryOpNode Expression(NumNode left, Token<FractalToken> operatorToken, ExprNode right)
        {
            // Console.WriteLine($"Parsed expr - term [ PLUS | MINUS ] expression : {left} {operatorToken} {right}");
            return new BinaryOpNode(left, operatorToken, right);
        }

        [Production("term: INT")]
        public NumNode Expression(Token<FractalToken> intToken)
        {
            // Console.WriteLine($"Parsed term INT : {intToken}");
            return new NumNode(intToken);
        }
    }
}