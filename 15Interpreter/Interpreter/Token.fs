namespace Interpreter

type TokenType = 
    | Integer = 0
    | Plus = 1
    | Minus = 2
    | Lparen = 3
    | Rparen = 4

type Token(aType: TokenType, text: string) =
    member val Type = aType
    member val Text = text

    override this.ToString() = sprintf "`%s`" this.Text