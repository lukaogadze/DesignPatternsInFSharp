namespace Decorator

open System.Text

type CodeBuilder() =
    let _builder = StringBuilder()
    member this.ImportantInfo = fun () ->  "You can use decorator to extend sealed class"
    

