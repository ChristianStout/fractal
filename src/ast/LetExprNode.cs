using fractal.src.visitors;
using sly.lexer;

namespace fractal.src.ast;

public class LetExprNode : ExprNode
{
    public IdNode id;
    public ExprNode expr;
    public bool mutable;

    public LetExprNode(IdNode Id, Node Expr, bool Mutable = false)
    {
        id = Id;
        expr = (ExprNode)Expr;
        mutable = Mutable;
    }

    public override void Accept(IVisitor visitor)
    {
        visitor.PreVisitLetExpr(this);
        visitor.VisitLetExpr(this);

        id.Accept(visitor);
        expr.Accept(visitor);

        visitor.PostVisitLetExpr(this);
    }
}