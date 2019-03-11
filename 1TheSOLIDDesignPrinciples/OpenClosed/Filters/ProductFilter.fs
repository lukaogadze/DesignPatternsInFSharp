namespace OpenClosed.Filters

open OpenClosed.Products

type ProductFilter() =
    member this.FilterBySize(products: seq<Product>, size: Size) =
        products |> Seq.filter (fun p -> p.Size = size)
    
    member this.FilterByColor(products: seq<Product>, color: Color) =
        products |> Seq.filter (fun p -> p.Color = color)

    member this.FilterBySizeAndColor(products: seq<Product>, size: Size, color: Color) =
        products |> Seq.filter (fun p -> p.Size = size && p.Color = color)
        
