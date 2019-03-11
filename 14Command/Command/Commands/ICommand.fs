namespace Command.Commands

type ICommand =
    abstract member Call : unit -> unit
    abstract member Undo : unit -> unit