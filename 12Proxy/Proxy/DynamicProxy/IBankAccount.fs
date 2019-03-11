namespace Proxy.DynamicProxy

type IBankAccount =
    abstract member Deposit : int -> unit
    abstract member Withdraw : int -> bool
    abstract member ToString : unit -> string

