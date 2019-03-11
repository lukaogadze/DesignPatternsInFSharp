namespace Decorator.MultipleInheritance

type ILizard =
    abstract member Crawl : unit -> unit
    abstract member Weight : int with get, set

