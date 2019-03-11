namespace Observer

open System

type FallsIllEventArgs(address: string) =
    inherit EventArgs()
    member this.Address = address


