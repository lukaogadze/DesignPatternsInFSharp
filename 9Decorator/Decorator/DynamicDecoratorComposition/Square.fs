namespace Decorator.DynamicDecoratorComposition

type Square(side: float) =
    interface IShape with
        member this.AsString() = sprintf "A square with side %A" side

