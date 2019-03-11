namespace Decorator.StaticDecoratorComposition

type Circle(radius: float) =
    inherit Shape()
    let mutable _radius = radius
    new () = Circle(0.)
                        
    member this.Resize factor =
        _radius <- _radius * factor
        
    override this.AsString() = sprintf "A circle with radius %A" _radius                               