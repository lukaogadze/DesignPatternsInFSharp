namespace NullObject

type ConsoleLog() =
    interface ILog with
        member this.Info message = printfn "%s" message
        member this.Warn message = printfn "WARNING!!! %s" message

