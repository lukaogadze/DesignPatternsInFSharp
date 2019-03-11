namespace Decorator.StaticDecoratorComposition
open System
open System


//type ColoredShape(shape: Shape, color: string) =    
//    inherit Shape()
//    override this.AsString() = sprintf "%s has the color %s" (shape.AsString()) color

type ColoredShape<'T when 'T:(new : unit -> 'T) and 'T :> Shape>(color: string) =
    inherit Shape()
    let shape = Activator.CreateInstance(typedefof<'T>) :?> Shape
    new () = ColoredShape("black")
    
    override this.AsString() = sprintf "%s has color %s" (shape.AsString()) color
    
    