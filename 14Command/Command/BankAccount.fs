namespace Command

type BankAccount() =
    let mutable _balance = 0
    let _overdraftLimit = -500

    member internal this.Deposit(amount) =
        _balance <- amount + _balance
        printfn "Deposited $%d, balance is now $%d" amount _balance

    member internal this.Withdraw(amount) =
        if (_balance - amount >= _overdraftLimit) then
            _balance <- _balance - amount
            printfn "Withdrew $%d, balance is now $%d" amount _balance
            true
        else
            false

    override this.ToString() = sprintf "Balance: $%d" _balance
    
