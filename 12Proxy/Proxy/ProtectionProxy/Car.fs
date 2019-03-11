namespace Proxy.ProtectionProxy

type Car() =
    interface ICar with
        member this.Drive() =
            printfn "Car is begin driven"