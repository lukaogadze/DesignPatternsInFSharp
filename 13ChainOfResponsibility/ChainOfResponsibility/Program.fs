module ChainOfResponsibility.Program
open ChainOfResponsibility.BrokerChains

let private sample3() =    
//    let goblin = new ChainOfResponsibility.Creature("Goblin", 2, 2)
//    printfn "%A" goblin
//
//    let root = CreatureModifier(goblin)
//
//    // root.Add(NoBonusModifier(goblin))
//
//    printfn "Let's double the goblin's attack"
//    root.Add(DoubleAttackModifier(goblin))
//
//    let additionalDefence = 4
//    printfn "Let's Increase the goblin's Defence by %d" additionalDefence
//    root.Add(IncreasingDefenceModifier(goblin, additionalDefence))
//
//
//    root.Handle()
//
//    printfn "%A" goblin
    ()

let private sample4() =
    let game = Game()
    let goblin = Creature(game, "Strong Goblin", 20, 20)
    printfn "%A" goblin
    using(new DoubleAttackModifier(game, goblin)) (fun _ ->
        printfn "%A" goblin
        using(new IncreaseDefenceModifier(game, goblin)) (fun _ ->
            printfn "%A" goblin) )
    printfn "%A" goblin        
    ()        

[<EntryPoint>]
let main argv =
    sample4()               
    0
