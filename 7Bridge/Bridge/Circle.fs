namespace Bridge

type Circle(renderer: IRenderer, radius: float) =
    inherit Shape(renderer)
    let mutable _radius = radius
    
    override this.Draw() =
        renderer.RenderCircle(_radius)
        
    override this.Resize(factor) =
        _radius <- factor * _radius
        