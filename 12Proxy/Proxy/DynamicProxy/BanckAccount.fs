namespace Proxy.DynamicProxy

type BanckAccount() =
    let mutable _balance = 0
    let _overDraftLimit = -500
    
    interface IBankAccount with
        member this.Deposit amount =
            _balance <- _balance + amount
            printfn "Deposited %d, balance is now %d" amount _balance
            
        member this.Withdraw amount =
            let isWithdrawable = _balance - amount >= _overDraftLimit
            match isWithdrawable with
            | true ->
                _balance <- _balance - amount
                printfn "Withdrew %d, balance is now %d" amount _balance
                true
            | _ -> false
            
        member this.ToString() =
            sprintf "%s: %d" "balance" _balance