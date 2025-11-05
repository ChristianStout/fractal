
using fractal.src.ast;

namespace fractal.src.visitors
{
    public abstract class IVisitor
    {
        public abstract void Visit(Node node);

        public abstract void VisitRoot(RootNode node);

        public abstract void VisitStmt(StmtNode node);

        public abstract void VisitExpr(ExprNode node);

        public abstract void VisitExprStmt(ExprStmtNode node);

        public abstract void VisitNum(NumNode node);

        public abstract void VisitBinaryOp(BinaryOpNode node);
    }
}
