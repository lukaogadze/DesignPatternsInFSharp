namespace Decorator.MultipleInheritance

type Bird() =
    interface IBird with
        member val Weight = 0 with get, set
        member this.Fly() =
            printfn "Soaring in the sky with weight %d" ((this :> IBird).Weight)