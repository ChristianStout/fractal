using fractal.src.visitors;
using sly.lexer;

namespace fractal.src.ast;

public class LetExprNode : ExprNode
{
    Token<FractalToken> id;
    ExprNode expr;
    bool mutable;

    public LetExprNode(Token<FractalToken> Id, Node Expr, bool Mutable = false)
    {
        id = Id;
        expr = (ExprNode)Expr;
        mutable = Mutable;
    }

    public override void Accept(IVisitor visitor)
    {
        visitor.PreVisitLetExprNode(this);
        visitor.VisitLetExprNode(this);

        visitor.VisitExpr(expr);

        visitor.PostVisitLetExprNode(this);
    }
}