module Strategy.Program

let private sample1() =
//    let tp = TextProcessor(MarkdownListStrategy())
//    tp.AppendList ["foo";"bar";"baz"]
//    printfn "%A"tp
//    
//    tp.Clear()
//    
//    tp.SetProcessingStrategy(HtmlListStrategy())    
//    tp.AppendList ["foo";"bar";"baz"]
//    printfn "%A"tp
    () 

[<EntryPoint>]
let main argv =
    let mutable tp = TextProcessor<HtmlListStrategy>()
    tp.AppendList ["foo";"bar";"baz"]
    printfn "%A"tp
    
    let tp2 = TextProcessor<MarkdownListStrategy>()    
    tp2.AppendList ["foo";"bar";"baz"]
    printfn "%A"tp2
    0
