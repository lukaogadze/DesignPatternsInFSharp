namespace Observer.WeakEvent

type Button() =
    let _event = Event<_>()

    [<CLIEvent>]
    member this.Clicked = _event.Publish

    member this.Fire() =
        _event.Trigger()        

