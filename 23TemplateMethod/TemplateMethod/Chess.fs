namespace TemplateMethod

type Chess() =
    inherit Geme(2)
    let mutable _turn = 1
    let _maxTurns = 10

    
    override this.Start() = printfn "Starting a game of chess with %d players." this.NumberOfPlayers
    override this.TakeTurn() =
        printfn "Turn %d taken by player %d" _turn this.CurrentPlayer
        _turn <- _turn + 1
        this.CurrentPlayer <- (this.CurrentPlayer + 1) % this.NumberOfPlayers
        
    override this.HaveWinner = _turn = _maxTurns
    override this.WinningPlayer = this.CurrentPlayer
