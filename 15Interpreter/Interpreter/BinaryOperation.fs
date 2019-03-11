namespace Interpreter

type BinaryOperationType =
    | Addition = 0
    | Subtraction = 1

type BinaryOperation() =
    [<DefaultValue>]
    val mutable Type : BinaryOperationType
    [<DefaultValue>]
    val mutable Left : IElement
    [<DefaultValue>]
    val mutable Right : IElement
    
    interface IElement with
        member this.Value =
            match this.Type with
            | BinaryOperationType.Addition -> this.Left.Value + this.Right.Value
            | _ -> this.Left.Value - this.Right.Value