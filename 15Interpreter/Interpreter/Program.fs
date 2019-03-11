module Interpreter.Program

open System.Text
open System


let private lex (input: string) =
    let mutable result = List<Token>.Empty
    let mutable numberIsProcessing = false
    let sb = StringBuilder()
    let processSymbols c =
        match c with
        | '+' -> result <- result @ [Token(TokenType.Plus, "+")]
        | '-' -> result <- result @ [Token(TokenType.Minus, "-")]
        | '(' -> result <- result @ [Token(TokenType.Lparen, "(")]
        | ')' -> result <- result @ [Token(TokenType.Rparen, ")")]
        | _ ->   numberIsProcessing <- true  
                 sb.Append(c.ToString()) |> ignore

    for c in input do
        if not numberIsProcessing then
            processSymbols(c)
        else
            match c with
            | i when Char.IsDigit i -> sb.Append(c.ToString()) |> ignore
            | _ -> numberIsProcessing <- false
                   result <- result @ [Token(TokenType.Integer, sb.ToString())]
                   sb.Clear() |> ignore
                   processSymbols c
    result

let rec private parse(tokens: Token list): IElement =
//    let result = BinaryOperation()
//    let mutable haveLeftHandSide = false
//    for i = 0 to tokens.Length do
//        let token = tokens.[i] // dont use list type if you need to use indexer....
//        match token.Type with
//        | TokenType.Integer ->
//            let integer = Integer(token.Text |> int)
//            if not haveLeftHandSide then
//                result.Left <- integer
//            else
//               result.Right <- integer 
//        | TokenType.Plus -> result.Type <- BinaryOperationType.Addition
//        | TokenType.Minus -> result.Type <- BinaryOperationType.Subtraction
//        | TokenType.Lparen ->
//            let mutable breakLoop = false
//            let mutable je = 0 
//            while not breakLoop do
//                for j = (i + 1) to tokens.Length do
//                    if tokens.[j].Type = TokenType.Rparen then
//                        breakLoop <- true
//                        je <- j
//            let subExpression = tokens |> List.skip (i + 1) |> List.take (je - i - 1)
//            let element = parse(subExpression)
//            if not haveLeftHandSide then
//                result.Left <- element
//            else
//               result.Right <- element 
//        | _ -> raise(ArgumentOutOfRangeException())
//    result
        Integer(0) :> IElement


[<EntryPoint>]
let main argv =
    let input = "(13+4)-(12+1)"
    let tokens = lex(input)
    printfn "%s" (String.Join("\t", tokens))
    0
