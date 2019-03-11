namespace Observer.WeakEvent

open System

[<AllowNullLiteral>]
type Window(button: Button) =    
    let handler = Handler<unit>(fun _ _ -> printfn "Button clicked (Window handler: LET)")
    do button.Clicked.AddHandler(handler)
            
    interface IDisposable with
        member this.Dispose() =
            button.Clicked.RemoveHandler(handler)