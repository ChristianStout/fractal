
using fractal.src.visitors;
using sly.lexer;
using sly.parser.generator;
using src.parser;

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

        public override void Accept(IVisitor visitor)
        {
            visitor.PreVisitBinaryOp(this);

            leftChild.Accept(visitor);
            visitor.VisitBinaryOp(this);
            rightChild.Accept(visitor);

            visitor.PostVisitBinaryOp(this);
        }
    }
}
