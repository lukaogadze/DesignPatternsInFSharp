namespace Visitor

type IExpressionVisitor =
    abstract Visit : IDoubleExpression -> unit
    abstract Visit : IAdditionExpression -> unit    