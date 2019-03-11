module Command.Program

open Command.Commands
open System.Linq

[<EntryPoint>]
let main argv =
    let bankAccount = BankAccount()
    let commands: ICommand list = [
        BankAccountCommand(bankAccount, BankCommandActions.Deposit, 100)
        BankAccountCommand(bankAccount,BankCommandActions.Withdraw, 1000)
    ]

    printfn "%A" bankAccount


    commands |> List.iter (fun c -> c.Call())

    printfn "%A" bankAccount

    commands |> List.rev |> List.iter (fun c -> c.Undo())    
    
    printfn "%A" bankAccount
    0
