module Factories.Program

open Factories.AbstractFactory
open System

let private factoryMethod() =
    // let point = Point.NewPolarPoint(1.0, Math.PI / 2.0)
    // printfn "%A" point
    ()
   
[<EntryPoint>]
let main argv =
    let hotDrinkMachine = HotDrinkMachine()
    let drink = hotDrinkMachine.MakeDrink()
    drink.Consume()
    0
