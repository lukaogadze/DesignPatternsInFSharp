namespace ChainOfResponsibility

type IncreasingDefenceModifier(creature, additionalDefence: int) =
    inherit CreatureModifier(creature)

    override this.Handle() =
        printfn "Increasing %s's Defence by %d" this.Creature.Name additionalDefence
        this.Creature.Defence <- this.Creature.Defence + additionalDefence
        base.Handle()