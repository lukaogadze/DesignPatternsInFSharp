namespace Flyweight.TextFormatter
open System
open System.Collections.Generic
open System.Text


type BetterFormattedText(plainText: string) =
    let _formatting = List<TextRange>()
    
    member this.GetRange(start: int, aEnd: int) =
        let range = TextRange(start, aEnd)
        _formatting.Add range
        range
        
    override this.ToString() =
        let sb = StringBuilder()
        for i = 0 to plainText.Length - 1 do
            let mutable c = plainText.[i]
            for range in _formatting do
                if range.Covers(i) && range.Capitalize then
                    c <- Char.ToUpper c
            sb.Append(c) |> ignore
        sb.ToString()            
                    