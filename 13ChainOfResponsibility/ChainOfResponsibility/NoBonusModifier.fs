namespace ChainOfResponsibility

type NoBonusModifier(creature) =
    inherit CreatureModifier(creature)

    override this.Handle() =
        ()