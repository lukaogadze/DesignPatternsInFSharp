module Builder.Program

open Builder.PersonBuilder

open System
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
    let builder = PersonBuilder(Person())
    let person = builder.Lives
                        .At("123 London Road")
                        .In("London")
                        .WithPostCode("SW12CA")
                                .Works
                                .At("Fabrikam")
                                .As("Engineer")
                                .Earning(2002313)
                                    .Build()                                    

    printfn "%A" person

    
        
            
            

            
            
            

[<EntryPoint>]
let main argv =  
    personBuilderExample()
    0


    //let person = pb.Lives
    //    .At("123 London Road")
    //    .In("London")
    //    .WithPostCode("SW12CA")
    //        .Works
    //        .At("Fabrikam")
    //        .As("Engineer")
    //        .Earning(123000)