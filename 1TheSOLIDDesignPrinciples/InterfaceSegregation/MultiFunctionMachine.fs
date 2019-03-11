namespace InterfaceSegregation

// Decorator
type MultiFunctionMachine(printer: IPrinter, scanner: IScanner) =
    interface IMultiFunctionDevice with
        member this.Print document = printer.Print document
        member this.Scan document = scanner.Scan document

