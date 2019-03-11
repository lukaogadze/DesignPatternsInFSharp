namespace OpenClosed.Specifications


type ISpecification<'a> =
    abstract IsSatisfiedBy : 'a -> bool