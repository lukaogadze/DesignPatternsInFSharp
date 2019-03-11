namespace Command.Commands

open Command

type BankAccountCommand(bankAccount: BankAccount, action: BankCommandActions, amount: int) = 
    let mutable _succeeded = false
    interface ICommand with
        member this.Call() =
            match action with
            | BankCommandActions.Deposit -> 
                bankAccount.Deposit(amount)
                _succeeded <- true
            | _ -> 
                _succeeded <- bankAccount.Withdraw(amount)
        
        member this.Undo() =
            if not _succeeded then
                ()
            else 
                match action with
                | BankCommandActions.Deposit -> bankAccount.Withdraw(amount) |> ignore
                | _ -> bankAccount.Deposit(amount)