module NullObject.Program

open System
open Autofac
open NullObject.DynamicNullObject

[<EntryPoint>]
let main argv =
    //let log = ConsoleLog()
    //let ba = BankAccount(log)
    //ba.Deposit 100

    //let cb = ContainerBuilder()
    //cb.RegisterType<BankAccount>() |> ignore
    //cb.RegisterType<NullLog>().As<ILog>() |> ignore
    //using(cb.Build()) (fun container -> 
    //    let ba = container.Resolve<BankAccount>()
    //    ba.Deposit 100
    //)

    let log = Null<ILog>.Instance
    log.Warn("saddsasda")
    let ba = BankAccount(log)
    ba.Deposit 50
    0
