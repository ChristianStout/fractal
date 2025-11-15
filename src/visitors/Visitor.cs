
using fractal.src.ast;

namespace fractal.src.visitors
{
    public class IVisitor
    {
        // PRE VISIT METHODS
        public virtual void PreVisit(Node node) {}
        public virtual void PreVisitRoot(RootNode node) {}
        public virtual void PreVisitStmt(StmtNode node) {}
        public virtual void PreVisitExpr(ExprNode node) {}
        public virtual void PreVisitExprStmt(ExprStmtNode node) {}
        public virtual void PreVisitNum(NumNode node) {}
        public virtual void PreVisitBinaryOp(BinaryOpNode node) {}
        public virtual void PreVisitLetExprNode(LetExprNode node) {}

        // MIDDLE VISIT METHODS
        public virtual void Visit(Node node) {}
        public virtual void VisitRoot(RootNode node) {}
        public virtual void VisitStmt(StmtNode node) {}
        public virtual void VisitExpr(ExprNode node) {}
        public virtual void VisitExprStmt(ExprStmtNode node) {}
        public virtual void VisitNum(NumNode node) {}
        public virtual void VisitBinaryOp(BinaryOpNode node) {}
        public virtual void VisitLetExprNode(LetExprNode node) {}

        // POST VISIT METHODS
        public virtual void PostVisit(Node node) {}
        public virtual void PostVisitRoot(RootNode node) {}
        public virtual void PostVisitStmt(StmtNode node) {}
        public virtual void PostVisitExpr(ExprNode node) {}
        public virtual void PostVisitExprStmt(ExprStmtNode node) {}
        public virtual void PostVisitNum(NumNode node) {}
        public virtual void PostVisitBinaryOp(BinaryOpNode node) {}
        public virtual void PostVisitLetExprNode(LetExprNode node) {}
    }
}
