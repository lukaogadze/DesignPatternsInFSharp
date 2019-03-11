namespace Singleton.Monostate

type CEO() =
    static let mutable name = ""
    static let mutable age = 0
    
    member this.Name
        with get() = name
        and set value = name <- value
        
    member this.Age
        with get() = age
        and set value = age <- value
    
    override this.ToString() =
        sprintf "%s: %s, %s: %d" "Name" this.Name "Age" this.Age

