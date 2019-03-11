namespace Strategy

type MarkdownListStrategy() =
    interface IListStrategy with
        member this.Start builder = ()
        member this.End builder = ()
        member this.AddListItem builder item =
            builder.AppendLine (sprintf " * %s" item) |> ignore
