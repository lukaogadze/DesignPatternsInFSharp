namespace ChainOfResponsibility.BrokerChains

type Creature(game: Game, name: string, attack: int, defence: int) =
    member this.Name = name
    
    member this.Attack
        with get() =
            let q = Query(name, Argument.Attack, attack)
            game.PerformQuery(q)
            q.Value
            
    member this.Defence
        with get() =
            let q = Query(name, Argument.Defence, defence)
            game.PerformQuery(q)
            q.Value
            
    override this.ToString() =
        sprintf "%s: %s, %s: %d, %s: %d" "Name" this.Name "Attack" this.Attack "Defence" this.Defence 