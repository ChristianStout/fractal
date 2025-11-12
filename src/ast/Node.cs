
using System.Runtime.InteropServices.Swift;
using fractal.src.visitors;
using sly.lexer;

namespace fractal.src.ast
{
    public abstract class Node {
        public abstract void Accept(IVisitor visitor);
    }
}
