namespace Visitor

type IAdditionExpression =
    inherit IExpression
    abstract Left : IExpression with get
    abstract Right : IExpression with get

