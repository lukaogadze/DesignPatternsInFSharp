namespace Factories.AbstractFactory

type HotChocolateFactory() =
    interface IHotDrinkFactory with
        member this.Prepare amount =
            printfn "Put in a Cup, boil water, pour %d ml, add milk, enjoy!" amount
            HotChocolate() :> IHotDrink    

