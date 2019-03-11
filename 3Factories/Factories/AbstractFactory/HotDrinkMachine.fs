namespace Factories.AbstractFactory
open System
open System.Collections.Generic



//type HotDrinkMachine() =
//    let factories = Dictionary<AvailableDrink, IHotDrinkFactory>()
//    do
//        for drink in Enum.GetValues(typeof<AvailableDrink>) do
//            let factory = Activator.CreateInstance(Type.GetType("Factories.AbstractFactory." + Enum.GetName(typeof<AvailableDrink>, drink) + "Factory"))
//                                        :?> IHotDrinkFactory
//            factories.Add(drink :?> AvailableDrink, factory)


//    member this.MakeDrink(drink: AvailableDrink, amount: int) =
//        factories.[drink].Prepare(amount)

type HotDrinkMachine() =
    let _factories = List<string * IHotDrinkFactory>()
    do
        for t in (typeof<HotDrinkMachine>.Assembly.GetTypes()) do
            if typeof<IHotDrinkFactory>.IsAssignableFrom(t) && not t.IsInterface then
                let drink = t.Name.Replace("Factory", String.Empty)
                let factory = Activator.CreateInstance(t) :?> IHotDrinkFactory
                _factories.Add (drink, factory)
    
    member this.MakeDrink() =
        printfn "Available drinks:"
        for i in 0.._factories.Count - 1 do
            printfn "%d: %s" i (fst _factories.[i])

        let mutable userIsSelecting = true
        let mutable drink: IHotDrink = new Coffee() :> IHotDrink
        while userIsSelecting do
            let mutable s = Console.ReadLine()
            let drinkIndex = ref -1
            if not (String.IsNullOrWhiteSpace s) 
                && Int32.TryParse(s, drinkIndex) 
                && !drinkIndex >= 0 
                && !drinkIndex < _factories.Count then
                printf "Specify amount: "
                s <- Console.ReadLine()
                let amount = ref -1
                if not (String.IsNullOrWhiteSpace(s)) && Int32.TryParse(s, amount) && !amount > 0 then
                    drink <- (snd _factories.[!drinkIndex]).Prepare(!amount)
                    userIsSelecting <- false
            else
                printfn "Incorrect input, try again!"
        drink
                    