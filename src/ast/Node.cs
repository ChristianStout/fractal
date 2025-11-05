
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

        public void accept(Visitor visitor)
        {
            visitor.visit(this);
        }

        public void print()
        {
            this.print_indents(0);
        }

        public void print_helper(int indents)
        {
            print_indents(indents);
        }

        public void print_indents(int indents)
        {
            string ws = "";
            for (int i = 0; i < indents; i++)
            {
                if (i == indents - 1)
                {
                    ws += "└─ ";
                    break;
                }
                ws += "│ ";
            }
            Console.Write(ws);
        }
    }
}
