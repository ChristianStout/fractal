using sly.lexer;
using sly.lexer.fsm;
using sly.i18n;

namespace fractal.src
{

    public enum FractalTokenPrec
    {
        Addition = 10,
        Multiplication = 50,
    }
    public enum FractalToken
    {
        [Lexeme("[0-9]+")]
        INT,
        [Lexeme("[+]")]
        PLUS,
        [Lexeme("[-]")]
        MINUS,
        [Lexeme("[*]")]
        TIMES,
        [Lexeme("[/]")]
        DIVIDE,

        [Lexeme(";")]
        SEMICOLON,

        [Lexeme("[ \\t]+", isSkippable: true)] // the lexeme is marked isSkippable : it will not be sent to the parser and simply discarded.
        WS
    }
}