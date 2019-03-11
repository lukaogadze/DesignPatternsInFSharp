namespace OpenClosed.Specifications

type AndSpecification<'a>(firstSpec: ISpecification<'a>, secondSpec: ISpecification<'a>) =
    interface ISpecification<'a> with
        member this.IsSatisfiedBy(item: 'a) =
            firstSpec.IsSatisfiedBy item && secondSpec.IsSatisfiedBy item 
            