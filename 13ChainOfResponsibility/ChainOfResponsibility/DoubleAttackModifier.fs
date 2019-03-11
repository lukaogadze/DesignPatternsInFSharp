namespace ChainOfResponsibility

type DoubleAttackModifier(creature) =
    inherit CreatureModifier(creature)

    override this.Handle() =
        printfn "Doubling %s's attack" this.Creature.Name
        this.Creature.Attack <- this.Creature.Attack * 2
        base.Handle()
