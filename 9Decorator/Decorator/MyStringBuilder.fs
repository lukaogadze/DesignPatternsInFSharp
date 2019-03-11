namespace Decorator
open System.Text

type MyStringBuilder() =
    let _sb = StringBuilder()
    member this.ImportantInfo() = "You can use decorator and adapter to add new functionality, for example add implicit convertion string builder to string"

