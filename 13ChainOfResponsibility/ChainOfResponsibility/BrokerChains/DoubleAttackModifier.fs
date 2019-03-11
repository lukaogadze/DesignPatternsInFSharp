namespace ChainOfResponsibility.BrokerChains

type DoubleAttackModifier(game, creature) =
    inherit CreatureModifier(game, creature)
    
    override this.Handle sender query =
        if query.CreatureName = creature.Name && query.WhatToQuery = Argument.Attack then
            query.Value <- query.Value * 2               