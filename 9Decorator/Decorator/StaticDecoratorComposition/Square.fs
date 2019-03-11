namespace Decorator.StaticDecoratorComposition

type Square(side: float) =    
    inherit Shape()
    new () = Square(0.)
    override this.AsString() = sprintf "A square with side %A" side