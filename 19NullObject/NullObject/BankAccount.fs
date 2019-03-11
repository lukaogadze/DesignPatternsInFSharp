namespace NullObject

type BankAccount(log: ILog) =
    let mutable _balance = 0

    member this.Deposit amount =
        _balance <- _balance + amount
        log.Info(sprintf "Deposited %d, balance is now %d" amount _balance)