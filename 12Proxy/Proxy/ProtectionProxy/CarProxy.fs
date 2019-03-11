namespace Proxy.ProtectionProxy

type CarProxy(driver: Driver) =
    let car  = Car()
    interface ICar with
        member this.Drive() =
            if driver.Age >= 16 then
                (car :> ICar).Drive()
            else
                printfn "too young"