namespace Mediator.EventBroker

type PlayerSentOffEvent(name: string, reason: string) =
    inherit PlayerEvent(name)
    member this.Reason = reason

