namespace Visitor
open System.Text

type ExpressionPrinter() =
    let stringBuilder = StringBuilder()
    
    interface IExpressionVisitor with
        member this.Visit (de: IDoubleExpression) =
            stringBuilder.Append de.Value |> ignore
            
        member this.Visit (ae: IAdditionExpression) =
            stringBuilder.Append "(" |> ignore
            (ae.Left :?> Expression).Accept(this)
            stringBuilder.Append "+" |> ignore
            (ae.Right :?> Expression).Accept(this)
            stringBuilder.Append ")" |> ignore
            
    override this.ToString() = stringBuilder.ToString()                        