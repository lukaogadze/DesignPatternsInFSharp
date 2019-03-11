namespace Flyweight.TextFormatter
open System
open System.Text

type FormattedText(plainText: string) =
    let capitalize: bool[] = Array.init plainText.Length (fun i -> false)
    
    member this.Capitalize(start: int, aEnd: int) =
        for i = start to aEnd do
            capitalize.[i] <- true
    
    override this.ToString() =
        let sb = StringBuilder()
        for i in 0..plainText.Length - 1 do
            let c = plainText.[i]
            sb.Append(if capitalize.[i] then Char.ToUpper(c) else c) |> ignore
        sb.ToString()