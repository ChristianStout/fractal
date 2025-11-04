using sly.lexer;
using sly.parser.generator;
using System.Collections.Generic;
using sly.parser.parser;
using System.Reflection.Metadata.Ecma335;

namespace fractal.src
{
    public class FractalParser
    {
        [Production("expression: INT")]
        public int intExpr(Token<FractalToken> intToken)
        {
            Console.WriteLine($"Parsed expr INT : {intToken}");
            return intToken.IntValue;
        }


        [Production("expression: term MINUS expression")]
        [Production("expression: term PLUS expression")]
        public int Expression(int left, Token<FractalToken> operatorToken, int right) {

            Console.WriteLine($"Parsed expr - term [ PLUS | MINUS ] expression : {left} {operatorToken} {right}");
            switch (operatorToken.TokenID) {
                case FractalToken.PLUS: return left + right;
                case FractalToken.MINUS: return left - right;
            }
            return left + right;
        }

        // [Production("op: [ PLUS | MINUS ]")]
        // public FractalToken Operator(Token<FractalToken> operatorToken)
        // {
        //     return operatorToken.TokenID;
        // }
        
        [Production("term: INT")]
        public int Expression(Token<FractalToken> intToken) {
            Console.WriteLine($"Parsed term INT : {intToken}");
            return intToken.IntValue;
        }
    }
}