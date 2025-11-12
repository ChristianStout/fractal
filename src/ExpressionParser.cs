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

        [Production("root: statement*")]
        public Node Root(List<Node> nodes)
        {
            return new RootNode(nodes);
        }

        [Production("statement: expression SEMICOLON")]
        public StmtNode Statement(ExprNode node, Token<FractalToken> semicolon)
        {
            return new ExprStmtNode(node);
        }

        [Production("expression: INT")]
        public ExprNode intExpr(Token<FractalToken> intToken)
        {
            return new NumNode(intToken);
        }


        [Production("expression: term MINUS expression")]
        [Production("expression: term PLUS expression")]
        public ExprNode Expression(Node left, Token<FractalToken> operatorToken, Node right)
        {
            // Console.WriteLine($"Parsed expr - term [ PLUS | MINUS ] expression : {left} {operatorToken} {right}");
            return new BinaryOpNode(left, operatorToken, right);
        }

        [Production("term: INT")]
        public ExprNode Expression(Token<FractalToken> intToken)
        {
            // Console.WriteLine($"Parsed term INT : {intToken}");
            return new NumNode(intToken);
        }
    }
}