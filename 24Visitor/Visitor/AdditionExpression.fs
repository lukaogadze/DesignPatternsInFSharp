namespace Visitor

type AdditionExpression(left: IExpression, right: IExpression) =
    inherit Expression()
    
    interface IAdditionExpression with
        member this.Left = left
        member this.Right = right
    
    
    override this.Accept visitor =
        visitor.Visit this
    

