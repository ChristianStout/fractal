S       ::= <stmt>*
stmt    ::= <expr> ;
          | if <expr> <sblock>
          | while <expr> <sblock>
          | function <id> ( <params>? ) <sblock>
sblock  ::= { <stmt>* }
params  ::= <id> : <type> <param_p>*
param_p ::= , <id> : <type>
expr    ::= <term>
          | <term> + <expr>
          | <term> - <expr>
          | <term> * <expr>
          | <term> / <expr>
          | let mut? <id> = <expr>
          | <id> ( <expr>? )
term    ::= <num>
          | <id>
          | <str>
type    ::= i32
          | string
num     ::= [-]?[0-9]+
id      ::= [_a-zA-Z][_a-zA-Z0-9]
str     ::= "."