namespace Factories.AbstractFactory

type private Tea() =
    interface IHotDrink with
        member this.Consume() = printfn "This tea is nice but I'd prefer it with milk."