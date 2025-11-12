using fractal.src.visitors;

namespace fractal.src.ast
{
    public class ExprStmtNode : StmtNode
    {
        ExprNode expr;

        public ExprStmtNode(ExprNode node)
        {
            expr = node;
        }

        public override void Accept(IVisitor visitor)
        {
            visitor.PreVisitExprStmt(this);

            visitor.VisitExprStmt(this);
            expr.Accept(visitor);

            visitor.PostVisitExprStmt(this);
        }
    }
}