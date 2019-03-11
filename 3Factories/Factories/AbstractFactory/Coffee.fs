namespace Factories.AbstractFactory

type private Coffee() =
    interface IHotDrink with
        member this.Consume() = printfn "This coffee is sensational!"