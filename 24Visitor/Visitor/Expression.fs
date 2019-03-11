namespace Visitor
open System.Text

[<AbstractClass>]
type Expression() =
    interface IExpression
    abstract Accept : IExpressionVisitor -> unit
    