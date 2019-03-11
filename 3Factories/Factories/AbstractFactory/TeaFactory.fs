namespace Factories.AbstractFactory

type TeaFactory() =
    interface IHotDrinkFactory with
        member this.Prepare amount =
            printfn "Put in a tea bag, boil water, pour %d ml, add lemon, enjoy!" amount
            Tea() :> IHotDrink