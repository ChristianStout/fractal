using fractal.src.ast;

namespace fractal.src.visitors
{
    public class PrintTreeVisitor : IVisitor
    {
        public override void VisitRoot(RootNode node)
        {
            Console.WriteLine("Visiting root");
        }

        public override void VisitExprStmt(ExprStmtNode node)
        {
            Console.WriteLine("Visiting ExprStmtNode");
        }

        public override void VisitBinaryOp(BinaryOpNode node)
        {
            Console.WriteLine($"Visiting BinaryOpNode = {node.innerToken.Value}");
        }

        public override void VisitNum(NumNode node)
        {
            Console.WriteLine($"Visiting NumNode = {node.innerToken.Value}");
        }

        public override void Visit(Node node)
        {
            throw new NotImplementedException();
        }

        public override void VisitStmt(StmtNode node)
        {
            throw new NotImplementedException();
        }

        public override void VisitExpr(ExprNode node)
        {
            throw new NotImplementedException();
        }
    }
}