namespace InterfaceSegregation

type PhotoCopier() =
    interface IPrinter with
        member this.Print document = ()

    interface IScanner with
        member this.Scan document = ()

