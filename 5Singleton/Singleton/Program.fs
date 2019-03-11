module Singleton.Program
open Singleton.Monostate

let private singletonExamples() =
    let db = SingletonDatabase.Instance
    let city = "Tokyo"
    printfn "%s has population %d" city (db.GetPopulation(city))

let private monostateExample() =
    let ceo = CEO()
    ceo.Name <- "Adam Smith"
    ceo.Age <- 55
    let ceo2 = CEO();
    printfn "%A" ceo2
    printfn "never implement this, just don't!"

[<EntryPoint>]
let private main argv =
    monostateExample()
    0 
