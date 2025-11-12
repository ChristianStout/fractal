
using fractal.src.visitors;
using sly.lexer;
using src.parser;

namespace fractal.src.ast
{
    public class NumNode(Token<FractalToken> token) : ExprNode
    {
        public Token<FractalToken> innerToken = token;

        public override void Accept(IVisitor visitor)
        {
            visitor.PreVisitNum(this);

            visitor.VisitNum(this);

            visitor.PostVisit(this);
        }
    }
}
