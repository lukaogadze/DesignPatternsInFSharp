namespace Visitor

type IDoubleExpression =
    inherit IExpression
    abstract member Value : double with get

