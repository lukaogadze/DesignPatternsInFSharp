namespace Interpreter

type Integer(value) =
    interface IElement with
        member this.Value = value