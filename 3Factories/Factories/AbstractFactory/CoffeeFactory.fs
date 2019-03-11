namespace Factories.AbstractFactory

type CoffeeFactory() =
    interface IHotDrinkFactory with
        member this.Prepare amount =
            printfn "Grind some beans, boil water, pour %d ml, add cream and sugar, enjoy!" amount
            Coffee() :> IHotDrink