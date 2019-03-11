namespace Strategy
open System.Text

type IListStrategy =
    abstract member Start : StringBuilder -> unit
    abstract member End : StringBuilder -> unit
    abstract member AddListItem : StringBuilder -> string -> unit
    


