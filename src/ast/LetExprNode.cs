using fractal.src.visitors;
using sly.lexer;

namespace fractal.src.ast;

public class LetExprNode : ExprNode
{
    Token<FractalToken> id;
    Node expr;
    bool mutable;

    public LetExprNode(Token<FractalToken> id, Node expr, bool mutable = false)
    {
        id = id;

    }

    public override void Accept(IVisitor visitor)
    {
        visitor.PreVisitLetExprNode(this);
        visitor.VisitLetExprNode(this);
        visitor.PostVisitLetExprNode(this);
    }
}