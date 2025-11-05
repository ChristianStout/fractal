
using fractal.src.ast;

namespace fractal.src.visitors
{
    public interface Visitor
    {
        public void visit(Node node);
        public void visit(NumNode node);
        public void visit(BinaryOpNode node);
    }
}
