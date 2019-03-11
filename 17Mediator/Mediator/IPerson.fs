namespace Mediator

type IPerson =    
    abstract member Name : string with get
    abstract member Say : string -> unit
    abstract member PrivateMessage : string * string -> unit
    abstract member ReceiveMessage : string * string -> unit
    abstract member ChatRoom : IChatRoom option with get, set