namespace Decorator.DynamicDecoratorComposition

type ColoredShape(shape: IShape, color: string) =    
    interface IShape with
        member this.AsString() = sprintf "%s has the color %s" (shape.AsString()) color