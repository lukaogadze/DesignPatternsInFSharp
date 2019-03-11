namespace Visitor

type ExpressionCalculator() =
    let mutable result: double = 0.
    
    member this.Result
        with get() = result
        and private set v = result <- v
    
    interface IExpressionVisitor with
        member this.Visit (de: IDoubleExpression) =
            this.Result <- de.Value
            
        member this.Visit (ae: IAdditionExpression) =
            (ae.Left :?> Expression).Accept this
            let a = this.Result
            (ae.Right :?> Expression).Accept this
            let b = this.Result
            this.Result <- (a + b)

