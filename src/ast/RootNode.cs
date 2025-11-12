using fractal.src.visitors;

namespace fractal.src.ast
{
    public class RootNode(NodeList stmts) : Node
    {
        NodeList Children { get; set; } = stmts;

        public override void Accept(IVisitor visitor)
        {
            visitor.PreVisitRoot(this);

            visitor.VisitRoot(this);

            // foreach (StmtNode child in Children)
            // {
            //     child.Accept(visitor);
            // }

            Children.Accept(visitor);

            visitor.PostVisitRoot(this);
        }
    }
}