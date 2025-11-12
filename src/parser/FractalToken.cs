using sly.lexer;
using sly.lexer.fsm;
using sly.i18n;

namespace src.parser
{
    public enum FractalToken
    {
        [Keyword("let")]
        LET,
        [Keyword("mut")]
        MUT,
        [Keyword("print")]
        PRINT,
        [Keyword("if")]
        IF,
        [Keyword("else")]
        ELSE,
        [Keyword("while")]
        WHILE,
        [Keyword("true")]
        TRUE,
        [Keyword("false")]
        FALSE,
        [AlphaId]
        IDENTIFIER,
        [String("\"", "\\")]
        STRING,
        [Int]
        INT,
        [Sugar("!")]
        NOT,
        [Sugar("&&")]
        AND,
        [Sugar("||")]
        OR,
        [Sugar(">")]
        GREATER,
        [Sugar("<")]
        LESSER,
        [Sugar("==")]
        EQUALS,
        [Sugar("!=")]
        DIFFERENT,
        [Sugar(".")]
        CONCAT,
        [Sugar("=")]
        ASSIGN,
        [Sugar("+")]
        PLUS,
        [Sugar("-")]
        MINUS,
        [Sugar("*")]
        TIMES,
        [Sugar("/")]
        DIVIDE,
        [Sugar("(")]
        LPAREN,
        [Sugar(")")]
        RPAREN,
        [Sugar(";")]
        SEMICOLON,
        [Sugar("{")]
        LCURLY,
        [Sugar("}")]
        RCURLY,
    }
}