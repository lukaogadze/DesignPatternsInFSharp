namespace Observer

open System

type Person() =
    let _event = Event<FallsIllEventArgs>()

    [<CLIEvent>]
    member this.FallsIll = _event.Publish

    member this.CatchACold() = 
        _event.Trigger(FallsIllEventArgs("123 London Road"))



