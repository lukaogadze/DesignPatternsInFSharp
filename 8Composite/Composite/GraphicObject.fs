namespace Composite

open System.Collections.Generic
open System.Text
open System

type GraphicObject() = 
    let _children = lazy(List<GraphicObject>())
    member val Color = "" with get, set
    member this.Children = _children.Force()

    abstract Name : string with get, set
    default val Name = "Group" with get, set


    member private this.Print(stringBuilder: StringBuilder, depth: int): unit =
        stringBuilder.Append(new String('*', depth))
            .Append(if String.IsNullOrWhiteSpace(this.Color) then String.Empty else sprintf "%s " this.Color)
            .AppendLine(this.Name) |> ignore

        for child in this.Children do
            child.Print(stringBuilder, depth + 1)
        
        


    override this.ToString() =
        let sb = StringBuilder()
        this.Print(sb, 0)
        sb.ToString()
