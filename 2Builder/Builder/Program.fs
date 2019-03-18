module Builder.Program

open Builder.FacetedBuilder
open System.Text

let private stringBuilderExample() =
    let hello = "hello"
    let sb = StringBuilder()
    sb.Append "<p>" |> ignore
    sb.Append hello |> ignore
    sb.Append "</p>" |> ignore
    printfn "%A" sb

    let words = ["hello"; "world"]
    sb.Clear() |> ignore
    sb.Append "<ul>" |> ignore
    for word in words do
        sb.AppendFormat("<li>{0}</li>", word) |> ignore
    sb.Append "</ul>" |> ignore
    printfn "%A" sb



let private htmlElementBuilderExample() =
    let builder = HtmlBuilder(rootName = "ul");
    builder.AddChild(HtmlElement("li", "hello"))
        .AddChild (HtmlElement("li", "world")) |> ignore

    printfn "%A" builder

let private personBuilderExample() =
    let pb = PersonBuilder()
    let person = pb
                    .Lives
                    .At("123 London Road")
                    .In("London")
                    .WithPostcode("SW12A")
                        .Works
                        .At("Fabrikam")
                        .AsA("Engineer")
                        .Earning(123000)
                            .Build()
                            
    printfn "%A" person                            
                               

    
        
            
            

            
            
            

[<EntryPoint>]
let main argv =  
    // htmlElementBuilderExample()
    personBuilderExample()
    0