module State.Program
open System

let rules = Map.ofList [
    PhoneState.OffHook, [(PhoneTigger.CallDialed, PhoneState.Connecting)]
    
    PhoneState.Connecting, [(PhoneTigger.HungUp, PhoneState.OffHook)
                            (PhoneTigger.CallConnected, PhoneState.Connected)]
    
    PhoneState.Connected, [(PhoneTigger.LeftMessage, PhoneState.OffHook)
                           (PhoneTigger.HungUp, PhoneState.OffHook)
                           (PhoneTigger.PlaceOnHold, PhoneState.OnHold)]
    
    PhoneState.OnHold, [(PhoneTigger.TakenOffHold, PhoneState.Connected)
                        (PhoneTigger.HungUp, PhoneState.OffHook)]    
    ] 

[<EntryPoint>]
let main argv =
    let mutable state = PhoneState.OffHook
    while true do
        printfn "The phone is currently %A" state
        printfn "Select a trigger:"
        for i = 0 to rules.[state].Length - 1  do
            let t, _ = rules.[state].[i]
            printfn "%d. %A" i t
        let input = Console.ReadLine() |> int
        
        let _, s = rules.[state].[input]
        state <- s
    0
