
using fractal.src.visitors;
using sly.lexer;
using sly.parser.generator;

namespace fractal.src.ast
{
    public class BinaryOpNode : ExprNode
    {
        public Token<FractalToken> innerToken;
        public NumNode leftChild;
        public ExprNode rightChild;
        

        public BinaryOpNode(NumNode left, Token<FractalToken> token, ExprNode right)
        {
            innerToken = token;
            leftChild = left;
            rightChild = right;
        }
    }
}
