namespace OpenClosed.Specifications

open OpenClosed.Products

type ColorSpecification(color: Color) =
    interface ISpecification<Product> with
        member this.IsSatisfiedBy(product: Product) =
            product.Color = color

