using sly.lexer;
using sly.parser.generator;
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

        [Production("expression: LET ID EQUALS expression")]
        public ExprNode LetExpr(Token<FractalToken> let, Token<FractalToken> id, Token<FractalToken> e, Node expr)
        {
            return new LetExprNode(new IdNode(id.Value), expr);
        }

        [Production("expression: INT")]
        public ExprNode intExpr(Token<FractalToken> intToken)
        {
            return new NumNode(intToken);
        }

        // [Operation((int)FractalToken.PLUS, Affix.InFix, Associativity.Left, (int)FractalTokenPrec.Addition)]
        // [Operation((int)FractalToken.MINUS, Affix.InFix, Associativity.Left, (int)FractalTokenPrec.Addition)]
        // [Operation((int)FractalToken.TIMES, Affix.InFix, Associativity.Left, (int)FractalTokenPrec.Multiplication)]
        // [Operation((int)FractalToken.DIVIDE, Affix.InFix, Associativity.Left, (int)FractalTokenPrec.Multiplication)]

        [Production("expression: term MINUS expression")]
        [Production("expression: term PLUS expression")]
        [Production("expression: term TIMES expression")]
        [Production("expression: term DIVIDE expression")]
        public ExprNode Expression(Node left, Token<FractalToken> operatorToken, Node right)
        {
            // Console.WriteLine($"Parsed expr - term [ PLUS | MINUS ] expression : {left} {operatorToken} {right}");
            return new BinaryOpNode(left, operatorToken, right);
        }

        // [Operand]
        [Production("term: INT")]
        public ExprNode Expression(Token<FractalToken> intToken)
        {
            // Console.WriteLine($"Parsed term INT : {intToken}");
            return new NumNode(intToken);
        }
    }
}