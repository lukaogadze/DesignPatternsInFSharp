namespace Decorator.DynamicDecoratorComposition

type TransparentShape(shape: IShape, transparency: float) =    
    interface IShape with
        member this.AsString() = sprintf "%s has %.0f%% transparency" (shape.AsString()) (transparency * 100.)
