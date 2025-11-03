

using sly.lexer;

namespace fractal.src
{
    public enum Token
    {
        [Lexeme(";")]
        SEMICOLON = 1,

        [Lexeme("\\(")]
        R_PAREN = 2,

        [Lexeme("\\)")]
        L_PAREN = 3,

        [Lexeme("=")]
        EQUALS = 4,

        [Lexeme("let")]
        LET = 5,

        [Lexeme("\\+")]
        PLUS = 6,

        [Lexeme("-")]
        MINUS = 7,

        [Lexeme("\\*")]
        MUL = 8,

        [Lexeme("\\/")]
        DIV = 9,

        [Lexeme("[-]?[0-9]+")]
        NUM = 10,

        [Lexeme("[_a-zA-Z][_a-zA-Z0-9]*")]
        ID = 11,
    }
}