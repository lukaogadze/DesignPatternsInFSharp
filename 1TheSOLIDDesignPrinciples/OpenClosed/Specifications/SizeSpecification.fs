namespace OpenClosed.Specifications

open OpenClosed.Products

type SizeSpecification(size: Size) =
    interface ISpecification<Product> with
        member this.IsSatisfiedBy(product: Product) =
            product.Size = size