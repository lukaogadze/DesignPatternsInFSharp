namespace Adapter

open System


type Line(start: Point, aEnd: Point) =
    member this.Start = start
    member this.End = aEnd
    member internal this.Equals(other: Line) =
        obj.Equals(this.Start, other.Start) && obj.Equals(this.End, other.End)
    

    override this.Equals other =
        match other with
        | null -> false
        | i when obj.ReferenceEquals(this, i) -> true
        | i when (not (i.GetType().Equals(this.GetType()))) -> false
        | _ -> this.Equals(other :?> Line)

    override this.GetHashCode() =
        this.Start.GetHashCode() * 397 ^^^ this.End.GetHashCode() * 397