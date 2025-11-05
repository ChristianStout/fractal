
using fractal.src.ast;

namespace fractal.src.visitors
{
    public interface Visitor
    {
        public void visit(Node node);
    }
}
