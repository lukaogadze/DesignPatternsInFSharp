namespace Factories.AbstractFactory

type HotChocolate() =
    interface IHotDrink with
        member this.Consume() = printfn "This Hot Chocolate is very nice and sweet"