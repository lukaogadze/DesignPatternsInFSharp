namespace ChainOfResponsibility.BrokerChains

type IncreaseDefenceModifier(game, creature) =
    inherit CreatureModifier(game, creature)

    override this.Handle sender query =
        if query.CreatureName = creature.Name && query.WhatToQuery = Argument.Defence then
            query.Value <- query.Value * 2

