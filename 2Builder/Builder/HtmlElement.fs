namespace Builder

open System
open System.Text

type HtmlElement(name: string, text: string) =
    let _indentSize = 2    
    new () = HtmlElement("","")
    member val Name = name with get, set
    member val Text = text with get, set
    member val Elements = List<HtmlElement>.Empty with get, set

    member private this.ToString indent: string =
        let sb = StringBuilder()
        let i = new string(' ', _indentSize * indent)
        sb.AppendLine (sprintf "%s<%s>" i this.Name) |> ignore
        if not (String.IsNullOrWhiteSpace this.Text) then
            sb.Append (new string(' ', _indentSize * (indent + 1))) |> ignore
            sb.AppendLine text |> ignore
        
        for e in (this.Elements) do
            sb.Append (e.ToString(indent + 1)) |> ignore

        sb.AppendLine (sprintf "%s</%s>" i name) |> ignore
        sb.ToString()

    override this.ToString() = this.ToString(0)
