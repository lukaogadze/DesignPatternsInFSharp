namespace LiskovSubstitution

type Rectangle(width: int, height: int) =
    let mutable _width = width
    let mutable _height = height
    new () = Rectangle(0, 0)

    abstract Width : int with get, set
    abstract Height : int with get, set

    default this.Width with get() = _width and set(value) = _width <- value
    default this.Height with get() = _height and set(value) = _height <- value

    override this.ToString() =
        sprintf "%s: %d, %s: %d" "Width" (this.Width) "Height" (this.Height)