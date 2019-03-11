namespace Decorator.DynamicDecoratorComposition

type Circle(radius: float) =
    let mutable _radius = radius    
        
    member this.Resize factor =
        _radius <- _radius * factor
        
    interface IShape with
        member this.AsString() = sprintf "A circle with radius %A" _radius        
                    