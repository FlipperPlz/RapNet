grammar Poseidon;

@header { namespace Enfuck.generated.poseidon; }

computationalUnit: classDefinition* | EOF;

classDefinition: 'class' identifier classExtension? classBlock? ';';

classBlock: '{'
    (classDefinition | statement)*
'}';

classExtension: ':' identifier;

statement:
    variableAssignment |
    deleteStatement;

variableAssignment: variableDeclaratorId '=' (arrayInitializer | expression) ';';

variableDeclaratorId: identifier ('[' variableInitializer? ']')*;
variableInitializer : arrayInitializer | expression;
arrayInitializer: '{' (variableInitializer (',' variableInitializer)* )? ','* '}';

literal: literalNumeric | literalBoolean | literalString | literalNull;
literalBoolean: LITERAL_BOOLEAN;
literalString: LITERAL_STRING;
literalNull: LITERAL_NULL;
literalNumeric: literalInteger | literalFloat;
literalFloat: LITERAL_FLOAT;
literalInteger: LITERAL_INTEGER;

deleteStatement: 'delete' expression;

expression:
    primaryExpression |
    expression '[' expression ']' |
    expression suffix=('++'|'--') |
    prefix=('+'|'-'|'++'|'--') expression |
    expression (IDENTIFIER|parExpression) expression |
    expression '^' expression |
    expression op=('*'|'/'|'%') expression |
    expression op=('++'|'--'|'+'|'-') expression |
    expression op=('<<' | '>>') expression |
    expression op=('<=' | '>=' | '>' | '<') expression |
    expression op=('==' | '!=') expression |
    <assoc=right> expression op=('=' | '+=' | '-=' | '*=' | '/=') expression;

parExpression: '(' expression ')';

primaryExpression:
    '(' expression ')' |
    arrayInitializer |
    literal;

identifier: IDENTIFIER;

SINGLE_LINE_COMMENT: '//' ~[\r\n]*           -> skip;
EMPTY_DELIMITED_COMMENT: ('/*/' | '/**/')    -> skip;
DELIMITED_COMMENT: '/*' .*? '*/'             -> skip;
WHITESPACES: [\r\n \t]                       -> channel(HIDDEN);
PREPROCESS: '#' ~[\r\n]*                      -> channel(HIDDEN);

LITERAL_STRING: '"' (EnforceEscapeSequence | .)*? '"';
LITERAL_INTEGER: '-'? Digit+;
LITERAL_FLOAT: FloatingPoint | FloatingPointScientific | LITERAL_INTEGER ;
LITERAL_BOOLEAN: 'true' | 'false';
LITERAL_NULL: 'null' | 'NULL';

IDENTIFIER: [a-zA-Z0-9_]+;

fragment EnforceEscapeSequence:
    '\\\\' |
    '\\"' |
    '\\\'';

fragment Digit: [0-9];

fragment FloatingPoint: '-'? Digit* '.' Digit*;
fragment FloatingPointScientific: FloatingPoint SCIENTIFIC Digit*;


SCIENTIFIC : ('E'|'e') [+-];