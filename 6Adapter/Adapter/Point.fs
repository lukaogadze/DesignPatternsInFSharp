namespace Adapter

type Point(x: int, y: int) =
    member val X = x
    member val Y = y
    member internal this.Equals(other: Point) =
        this.X = other.X && this.Y = other.Y
    

    override this.Equals(other: obj) =
        match other with
        | null -> false
        | i when obj.ReferenceEquals(this, i) -> true
        | i when (not (i.GetType().Equals(this.GetType()))) -> false
        | _ -> this.Equals(other :?> Point)

    override this.GetHashCode() = (this.X * 397) ^^^ this.Y