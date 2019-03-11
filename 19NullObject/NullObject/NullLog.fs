namespace NullObject

type NullLog() =
    interface ILog with
       member this.Info _ = ()
       member this.Warn _ = ()
