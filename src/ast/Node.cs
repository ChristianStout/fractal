
using System.Runtime.InteropServices.Swift;
using fractal.src.visitors;
using sly.lexer;

namespace fractal.src.ast
{
    public abstract class Node
    {

        // Node(Token<FractalToken> token)
        // {
        //     innerToken = token;
        // }

        public abstract void Accept(IVisitor visitor);
        // {
        //     // visitor.Visit(this);
        // }
    }
}
