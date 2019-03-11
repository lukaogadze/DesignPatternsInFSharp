namespace ChainOfResponsibility

[<AllowNullLiteral>]
type CreatureModifier(creature: Creature) =
    let mutable _next : CreatureModifier = null

    member this.Add(creatureModifier: CreatureModifier) =
        if (not (isNull _next)) then 
            _next.Add(creatureModifier)
        else 
            _next <- creatureModifier

    member internal this.Creature = creature

    abstract member Handle : unit -> unit
    default this.Handle() = if not (_next |> isNull) then _next.Handle()

