using System.ComponentModel;
using System.Net.NetworkInformation;
using fractal.src.ast;

// ─ │ └─ ├─ ╰─

namespace fractal.src.visitors
{
    public class PrintTreeVisitor() : IVisitor
    {
        private string tree = "";
        private int indents = -1;

        public override void PreVisitRoot(RootNode node) {
            indents += 1;
            addLines();
        }

        public override void PreVisit(Node node) {
            indents += 1;
            addLines();
        }
        public override void PreVisitStmt(StmtNode node) {
            indents += 1;
            addLines();
        }
        public override void PreVisitExpr(ExprNode node) {
            indents += 1;
            addLines();
        }
        public override void PreVisitExprStmt(ExprStmtNode node) {
            indents += 1;
            addLines();
        }
        public override void PreVisitNum(NumNode node) {
            indents += 1;
            addLines();
        }
        public override void PreVisitBinaryOp(BinaryOpNode node) {
            indents += 1;
            addLines();
            tree += $"Visiting BinaryOpNode({node.innerToken.Value})";
        }
        public override void PreVisitLetExpr(LetExprNode node) {
            indents += 1;
            addLines();
        }
        public override void PreVisitId(IdNode node) {
            indents += 1;
            addLines();
        }

        // only nodes with children should `endChildren`
        public override void PostVisit(Node node) {
            indents -= 1;
            tree += "\n";
        }
        public override void PostVisitRoot(RootNode node) {
            indents -= 1;
            endChildren();
            Console.WriteLine(tree);
        }
        public override void PostVisitStmt(StmtNode node) {
            indents -= 1;
            // tree += "\n";
        }
        public override void PostVisitExpr(ExprNode node) {
            indents -= 1;
            // tree += "\n";
        }
        public override void PostVisitExprStmt(ExprStmtNode node) {
            indents -= 1;
            endChildren();
        }
        public override void PostVisitNum(NumNode node) {
            indents -= 1;
            // tree += "\n";
        }
        public override void PostVisitBinaryOp(BinaryOpNode node) {
            indents -= 1;
            endChildren();
        }
        public override void PostVisitLetExpr(LetExprNode node) {
            indents -= 1;
            endChildren();
        }
        public override void PostVisitId(IdNode node) {
            indents -= 1;
        }


        public override void VisitRoot(RootNode node)
        {
            tree += "root";
        }

        public override void VisitExprStmt(ExprStmtNode node)
        {
            tree += "exprStmt";
        }

        public override void VisitBinaryOp(BinaryOpNode node)
        {
        }

        public override void VisitNum(NumNode node)
        {
            tree += $"NumNode({node.innerToken.Value})";
        }

        public override void VisitLetExpr(LetExprNode node)
        {
            tree += $"LetStmt";
            if (node.mutable) {
                tree += " [MUTABLE]";
            }
        }
        public override void VisitId(IdNode node)
        {
            tree += $"Id({node.id})";
        }

        private void addLines()
        {
            tree += '\n';
            for (var i = 0; i < indents; i++)
            {
                if (i == indents - 1)
                {
                    tree += " ├─";
                    return;
                }
                tree += " │ ";
            }
        }

        private void endChildren()
        {
            char[] chars = tree.ToCharArray();
            for (var i = tree.Length; i < 0; i--)
            {
                if (chars[i] == '├')
                {
                    chars[i] = '└';
                    break;
                }
            }
            tree = new string(chars);
        }
    }
}