namespace fractal.src.ast
{
    public class ExprStmtNode : StmtNode
    {
        ExprNode expr;

        public ExprStmtNode(ExprNode node)
        {
            expr = node;
        }
    }
}