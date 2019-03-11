namespace Decorator.MultipleInheritance

type IBird =
    abstract Fly : unit -> unit
    abstract Weight : int with get, set

