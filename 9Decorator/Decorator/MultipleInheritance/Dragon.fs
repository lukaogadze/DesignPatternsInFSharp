namespace Decorator.MultipleInheritance

type Dragon(bird: IBird, lizard: ILizard) =
    let mutable _weight = 0
    member this.Weight
        with get() = _weight
        and set value =
            _weight <- value
            bird.Weight <- value
            lizard.Weight <- value
    
    interface IBird with
        member this.Fly() = bird.Fly()
        member val Weight = 0 with get, set
        
    interface ILizard with
        member this.Crawl() = lizard.Crawl()
        member val Weight = 0 with get, set
                