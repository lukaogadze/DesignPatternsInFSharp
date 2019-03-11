namespace Mediator.EventBroker

type PlayerEvent(name: string) =
    member this.Name = name