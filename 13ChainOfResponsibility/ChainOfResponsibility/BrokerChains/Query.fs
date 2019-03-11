namespace ChainOfResponsibility.BrokerChains

type Query(creatureName: string, whatToQuery: Argument, value: int) =
    member this.CreatureName = creatureName
    member this.WhatToQuery = whatToQuery    
    member  val Value = value with get, set

