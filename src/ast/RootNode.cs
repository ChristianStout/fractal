using fractal.src.visitors;

namespace fractal.src.ast
{
    public class RootNode(List<Node> stmts) : Node
    {
        List<Node> Children { get; set; } = stmts;

        public override void Accept(IVisitor visitor)
        {
            visitor.VisitRoot(this);

            foreach (Node child in Children)
            {
                child.Accept(visitor);
            }

        }
    }
}