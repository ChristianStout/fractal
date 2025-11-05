
using fractal.src.visitors;
using sly.lexer;

namespace fractal.src.ast
{
    public interface Node
    {
        // private readonly Token<FractalToken> innerToken;

        // Node(Token<FractalToken> token)
        // {
        //     innerToken = token;
        // }
        
        public void accept(Visitor visitor)
        {
            visitor.visit(this);
        }
    }
}
