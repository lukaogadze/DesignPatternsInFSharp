namespace ChainOfResponsibility.BrokerChains
open System


[<AbstractClass>]
type CreatureModifier(game: Game, creature: Creature) as x =    
    let handler = new Handler<Query>(x.Handle)
    do x.Game.Queries.AddHandler handler
    
    member internal this.Game: Game = game
    member internal this.Creature: Creature = creature

    interface IDisposable with
        member this.Dispose() =
            this.Game.Queries.RemoveHandler handler
             
    abstract member Handle : obj -> Query -> unit        