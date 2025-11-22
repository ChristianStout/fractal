using fractal.src.visitors;

namespace fractal.src.ast
{
    public abstract class ExprNode : Node
    {
        public override void Accept(IVisitor visitor)
        {
            // TODO: Have this function check the type and call that visit method
            if (GetType() == typeof(BinaryOpNode))
            {
                ((BinaryOpNode)this).Accept(visitor);
                return;
            }
            if (GetType() == typeof(LetExprNode))
            {
                ((LetExprNode)this).Accept(visitor);
                return;
            }
            if (GetType() == typeof(LetExprNode))
            {
                ((LetExprNode)this).Accept(visitor);
                return;
            }
            if (GetType() == typeof(NumNode))
            {
                ((NumNode)this).Accept(visitor);
                return;
            }
            if (GetType() == typeof(IdNode))
            {
                ((IdNode)this).Accept(visitor);
                return;
            }
            visitor.PreVisitExpr(this);
            visitor.VisitExpr(this);
            visitor.PostVisitExpr(this);
        }
    }
}