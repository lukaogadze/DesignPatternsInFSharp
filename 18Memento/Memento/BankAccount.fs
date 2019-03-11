namespace Monento

open System.Collections.Generic

type BankAccount(balance: int) =
    let mutable _balance = balance
    let _changes = new List<Momento>()
    let mutable _current = 0

    do
        _changes.Add(Momento(_balance))

    member this.Deposit amount : Momento =
        _balance <- _balance + amount
        let m = Momento(_balance)
        _changes.Add(m)
        _current <- _current + 1
        m

    member this.Restore (momentOPtion: Momento option): Momento option =
        match momentOPtion with
        | Some m ->_balance <- m.Balance
                   _changes.Add m
                   Some m

        | None -> None

    member this.Redo(): Momento option =
        if (_current + 1) < _changes.Count then
            _current <- _current + 1
            let m = _changes.[_current]
            _balance <- m.Balance
            Some m
        else          
            None

    member this.Undo(): Momento option =
        if _current > 0 then
            _current <- _current - 1
            let m = _changes.[_current]
            _balance <- m.Balance
            Some(m)
        else
            None
    


    override this.ToString() = sprintf "%s: %d" "Balance" _balance