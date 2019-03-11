module Prototype.Program

open System

[<EntryPoint>]
let main argv =
    let john = Person([|"John";"Smith"|], Address("London Road", 123))
    let jane = john.DeepCopyXml()

    jane.Names.[0] <- "Jane"
    jane.Address.HouseNumber <- 321

    printfn "%A" john
    printfn "%A" jane
    0
