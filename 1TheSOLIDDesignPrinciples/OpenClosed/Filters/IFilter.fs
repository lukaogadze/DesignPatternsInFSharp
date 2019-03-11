namespace OpenClosed.Filters
open OpenClosed.Specifications

type IFilter<'a> =
    abstract member Filter: seq<'a> * ISpecification<'a> -> seq<'a>