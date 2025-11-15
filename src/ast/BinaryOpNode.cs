
using fractal.src.visitors;
using sly.lexer;
using sly.parser.generator;

namespace fractal.src.ast
{
    public class BinaryOpNode : ExprNode
    {
        public Token<FractalToken> innerToken;
        public Node leftChild;
        public Node rightChild;


        public BinaryOpNode(Node left, Token<FractalToken> token, Node right)
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
