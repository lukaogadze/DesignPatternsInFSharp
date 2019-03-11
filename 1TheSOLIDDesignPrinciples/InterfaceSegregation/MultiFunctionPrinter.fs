namespace InterfaceSegregation

open System

type MultiFunctionPrinter() =
    interface IMachine with
        member this.Print document = ()
        member this.Scan document = ()
        member this.Fax document = ()