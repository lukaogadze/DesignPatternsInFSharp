open OpenClosed.Products
open OpenClosed.Filters
open OpenClosed.Specifications

[<EntryPoint>]
let main argv =
    let apple = Product("Apple",Color.Green, Size.Small)
    let tree = Product("Tree",Color.Green, Size.Large)
    let house = Product("House", Color.Blue, Size.Large)
    
    let products = [apple; tree; house]

    let pf = ProductFilter();

    printfn "\ngreen products (old):"
    for p in pf.FilterByColor(products, Color.Green) do
        printfn " - %s is green" p.Name

    printfn "\ngreen and small products (old):"
    for p in pf.FilterBySizeAndColor(products, Size.Small, Color.Green) do
        printfn " - %s is green and small" p.Name

    let bf = BetterFilter() :> IFilter<Product>

    printfn "\ngreen products (new):"
    for p in bf.Filter(products, ColorSpecification(Color.Green)) do
        printfn " - %s is green" p.Name
    
    printfn "\nLarge blue items"
    for p in bf.Filter(products, AndSpecification(SizeSpecification(Size.Large), ColorSpecification(Color.Blue))) do
        printfn " - %s is blue and large" p.Name

    0 // return an integer exit code
