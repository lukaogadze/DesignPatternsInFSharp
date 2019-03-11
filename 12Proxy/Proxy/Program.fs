module Proxy.Program
open Proxy.DynamicProxy
open Proxy.DynamicProxy
open Proxy.PropertyProxy
open Proxy.ProtectionProxy

let private sample1() =
    let driver = Driver(Age = 15)
    let car = CarProxy(driver) :> ICar
    car.Drive()
    driver.Age <- 19
    car.Drive()
    
let private sample2() =
    let creature = Creature()
    creature.Agility <- 10
    creature.Agility <- 10
    
let private sample3() =
//    let bankAccount = BanckAccount() :> IBankAccount
//    bankAccount.Deposit 100
//    bankAccount.Withdraw 50 |> ignore
//    printfn "%A" bankAccount
//    let ba = Log<BanckAccount>.As<IBankAccount>()
//    ba.Deposit 100
//    ba.Withdraw 50 |> ignore
//    printfn "%A" ba
//    printfn "%s" (ba :?> Log<BanckAccount>).Info
// this doesn't works on f#
    "fk"
    

[<EntryPoint>]
let main argv =
    
    0
