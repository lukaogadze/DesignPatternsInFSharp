namespace Strategy
open System
open System.Text

type TextProcessor<'ListStrategy when 'ListStrategy :> IListStrategy and 'ListStrategy: (new: unit -> 'ListStrategy)>() =
    let _stringBuilder = StringBuilder()
    let mutable _listStrategy = Activator.CreateInstance<'ListStrategy>()
    
    member val private ListStrategy = _listStrategy with get, set 
    
        
    member this.AppendList(items: string seq) =
        _listStrategy.Start _stringBuilder
        for item in items do
            _listStrategy.AddListItem _stringBuilder item
        _listStrategy.End _stringBuilder
    
    override this.ToString() = _stringBuilder.ToString()
    
    member this.Clear() = _stringBuilder.Clear() |> ignore
            