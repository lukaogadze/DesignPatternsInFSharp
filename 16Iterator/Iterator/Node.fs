namespace Iterator

[<AllowNullLiteral>]
type Node<'T>(value:'T, left: Node<'T>, right: Node<'T>) as x = 
    let mutable _parent: Node<'T> = null
    let mutable _left: Node<'T> = null
    let mutable _right: Node<'T> = null
    do        
        if (not (left |> isNull) && not (right |> isNull)) then
            _left <- left
            _right <- right
            _left.Parent <- x
            _right.Parent <- x
    new (value:'T) = Node(value, null, null)

    member this.Value = value
    member this.Parent
        with get() = _parent
        and set(v) = _parent <- v
    member this.Left = _left
    member this.Right = _right