namespace Visitor

type DoubleExpression(value: double) =
    inherit Expression()
        
    override this.Accept visitor =
        // double dispach
        visitor.Visit(this)
        
        
    interface IDoubleExpression with
        member this.Value = value        

