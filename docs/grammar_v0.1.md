S       ::= <stmt>*
stmt    ::= let <id> = <expr> ;
          | <expr> ;
          | print ( <expr> ) ;
expr    ::= <term>
          | <term> + <expr>
          | <term> - <expr>
          | <term> * <expr>
          | <term> / <expr>
term    ::= <num>
          | <id>
num     ::= [-]?[0-9]+
id      ::= [_a-zA-Z][_a-zA-Z0-9]