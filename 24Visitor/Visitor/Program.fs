module Visitor.Program
open System.Text

[<EntryPoint>]
let main argv =
    let e = AdditionExpression(DoubleExpression(1.), AdditionExpression(DoubleExpression(2.), DoubleExpression(3.)))
    let ep = ExpressionPrinter() :> IExpressionVisitor
    ep.Visit e
   
    printfn "%A" ep
    let calc = ExpressionCalculator() :> IExpressionVisitor
    calc.Visit e
    printfn "%A = %.0f" ep (calc :?> ExpressionCalculator).Result
    0
