namespace Decorator.StaticDecoratorComposition
open System

//type TransparentShape(shape: Shape, transparency: float) =    
//    inherit Shape()
//    override this.AsString() = sprintf "%s has %.0f%% transparency" (shape.AsString()) (transparency * 100.)

type TransparentShape<'T when 'T:(new : unit -> 'T) and 'T :> Shape>(transparency: float) =
    inherit Shape()
    let shape = Activator.CreateInstance(typedefof<'T>) :?> Shape
    new () = TransparentShape(0.)
    
    override this.AsString() = sprintf "%s has transparency %f.0%%" (shape.AsString()) (transparency * 100.)