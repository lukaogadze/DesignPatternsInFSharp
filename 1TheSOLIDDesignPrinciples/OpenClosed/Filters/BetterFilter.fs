namespace OpenClosed.Filters
open OpenClosed.Products
open OpenClosed.Specifications

type BetterFilter() =
    interface IFilter<Product> with
        member this.Filter(items: seq<Product>, spec: ISpecification<Product>) = 
            Seq.filter (spec.IsSatisfiedBy) items