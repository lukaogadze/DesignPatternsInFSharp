namespace Strategy

type HtmlListStrategy() =
    interface IListStrategy with
        member this.Start builder = builder.AppendLine "<ul>" |> ignore
        member this.End builder = builder.AppendLine "</ul>" |> ignore
        member this.AddListItem builder item =
            builder.AppendLine (sprintf "  <li>%s</li>" item) |> ignore

