namespace ChainOfResponsibility.BrokerChains

type Game() =
    let _event = Event<Query>()
    
    [<CLIEvent>]
    member this.Queries = _event.Publish
    member this.PerformQuery(query: Query) =
        _event.Trigger(query)
