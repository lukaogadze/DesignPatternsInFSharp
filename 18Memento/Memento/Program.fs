module Momento.Program

open Monento

let private sample1() =
    //let ba = BankAccount(100)
    //let m1 = ba.Deposit(50)
    //let m2 = ba.Deposit(25)
    //printfn "%A" ba

    //ba.Restore(m1)
    //printfn "%A" ba

    //ba.Restore(m2)
    //printfn "%A" ba
    ()

let private sample2(): unit =
    let ba = BankAccount(100)
    ba.Deposit 50 |> ignore
    ba.Deposit 25 |> ignore
    printfn "%A" ba

    ba.Undo() |> ignore
    printfn "Undo 1: %A" ba
    ba.Undo() |> ignore
    printfn "Undo 1: %A" ba
    ba.Redo() |> ignore
    printfn "Redo 1: %A" ba

[<EntryPoint>]
let main _ =
    sample2()
    0
