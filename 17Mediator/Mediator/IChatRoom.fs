namespace Mediator

type IChatRoom =
    abstract member Brodcast : string * string -> unit
    abstract member Message : string * string * string -> unit