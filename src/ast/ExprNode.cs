using fractal.src.visitors;

namespace fractal.src.ast
{
    public abstract class ExprNode : Node
    {
        public override void Accept(IVisitor visitor)
        {
            // TODO: Have this function check the type and call that visit method
            visitor.PreVisitExpr(this);
            visitor.VisitExpr(this);
            visitor.PostVisitExpr(this);
        }
    }
}