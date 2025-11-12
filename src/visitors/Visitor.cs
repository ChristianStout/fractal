
using fractal.src.ast;

namespace fractal.src.visitors
{
    public abstract class IVisitor
    {

        // POST VISIT
        public abstract void PreVisitBinaryOp(BinaryOpNode node);
        public abstract void PreVisit(Node node);
        public abstract void PreVisitRoot(RootNode node);
        public abstract void PreVisitStmt(StmtNode node);
        public abstract void PreVisitExpr(ExprNode node);
        public abstract void PreVisitExprStmt(ExprStmtNode node);
        public abstract void PreVisitNum(NumNode node);

        // VISIT
        public abstract void Visit(Node node);
        public abstract void VisitBinaryOp(BinaryOpNode node);

        public abstract void VisitRoot(RootNode node);

        public abstract void VisitStmt(StmtNode node);

        public abstract void VisitExpr(ExprNode node);

        public abstract void VisitExprStmt(ExprStmtNode node);

        public abstract void VisitNum(NumNode node);

        // POST VISIT
        public abstract void PostVisitBinaryOp(BinaryOpNode node);
        public abstract void PostVisit(Node node);
        public abstract void PostVisitRoot(RootNode node);
        public abstract void PostVisitStmt(StmtNode node);
        public abstract void PostVisitExpr(ExprNode node);
        public abstract void PostVisitExprStmt(ExprStmtNode node);
        public abstract void PostVisitNum(NumNode node);
    }
}
