namespace Proxy.PropertyProxy
open System
open System.Collections.Generic

[<AllowNullLiteral>]
type Property<'T when 'T : (new : unit -> 'T) and 'T: equality>(value : 'T) =
    let mutable _value = value
    new() = Property(Activator.CreateInstance<'T>())
    member this.Value
        with get() = _value
        and set(v:'T) =
            if obj.Equals(this.Value, v) then
                ()                   
            else
                printfn "Assigning %A to %A" v _value
                _value <- v                        

                    
    override this.Equals(other: obj) =
        match other with
        | null -> false
        | i when obj.ReferenceEquals(this, other) -> true
        | i when not (other.GetType().Equals(this.GetType())) -> false
        | _ -> this.Equals(other :?> Property<'T>)
        
    override this.GetHashCode() =
        _value.GetHashCode()        
    
    interface IEquatable<Property<'T>> with
        member this.Equals(other: Property<'T>) =
            match other with
            | null -> false        
            | i when obj.ReferenceEquals(this, i) -> true
            | _ -> EqualityComparer<'T>.Default.Equals(_value, other.Value)
    
    static member (==)(left: Property<'T>, right: Property<'T>) =
        obj.Equals(left, right)             
        
    static member (!=)(left: Property<'T>, right: Property<'T>) =
        not (obj.Equals(left, right))   
        
    static member ConvertTo(property: Property<'T>): 'T =
        property.Value
    
    static member ConvertTo<'T>(value: 'T): Property<'T> =
        Property<'T>(value)        
           