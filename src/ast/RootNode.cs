namespace fractal.src.ast
{
    public class RootNode(List<StmtNode> stmts) : Node
    {
        List<StmtNode> Children { get; set; } = stmts;
    }
}