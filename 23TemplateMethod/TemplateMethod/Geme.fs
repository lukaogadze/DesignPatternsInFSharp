namespace TemplateMethod

[<AbstractClass>]
type Geme(numberOfPlayers: int) =    
    
    member this.Run() =
        this.Start()
        while not this.HaveWinner do
            this.TakeTurn()
        printfn "Player %d wins." this.WinningPlayer                        
        
    member this.NumberOfPlayers = numberOfPlayers
    member val internal CurrentPlayer = 0 with get, set
    
    abstract member Start : unit -> unit
    abstract  TakeTurn  : unit -> unit
    abstract  HaveWinner  : bool  with get
    abstract WinningPlayer : int with get
        

