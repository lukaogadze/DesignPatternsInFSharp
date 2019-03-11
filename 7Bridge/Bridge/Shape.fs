namespace Bridge

[<AbstractClass>]
type Shape(renderer: IRenderer) =    
    member internal this.Renderer = renderer
    
    abstract member Draw : unit -> unit
    abstract member Resize : float -> unit