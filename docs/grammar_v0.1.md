S       ::= <stmt>*
stmt    ::= <expr> ;
expr    ::= <term>
          | <term> + <expr>
          | <term> - <expr>
          | <term> * <expr>
          | <term> / <expr>
          | let <id> = <expr>
          | print ( <expr> )
term    ::= <num>
          | <id>
          | <str>
num     ::= [-]?[0-9]+
id      ::= [_a-zA-Z][_a-zA-Z0-9]
str     ::= "."