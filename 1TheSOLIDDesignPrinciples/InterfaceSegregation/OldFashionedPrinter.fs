namespace InterfaceSegregation
open System

type OldFashionedPrinter() =
    interface IMachine with
        member this.Print document = ()
        member this.Scan document = raise(NotImplementedException())
        member this.Fax document = raise(NotImplementedException())