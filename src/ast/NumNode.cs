
using System.Runtime.InteropServices;
using fractal.src.visitors;
using sly.lexer;

namespace fractal.src.ast
{
    public class NumNode : ExprNode
    {
        private Token<FractalToken> innerToken;

        public NumNode(Token<FractalToken> token)
        {
            innerToken = token;
        }
    }
}
