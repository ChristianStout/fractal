using fractal.src.visitors;

namespace fractal.src.ast
{
    public class RootNode(List<StmtNode> stmts) : Node
    {
        List<StmtNode> Children { get; set; } = stmts;

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitRoot(this);

            foreach (StmtNode child in Children)
            {
                child.Accept(visitor);
            }

        }
    }
}