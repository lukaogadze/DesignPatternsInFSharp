namespace Mediator.EventBroker

type PlayerScoredEvent(name: string, goalsScored: int) =
    inherit PlayerEvent(name)

    member this.GoalsScored = goalsScored
