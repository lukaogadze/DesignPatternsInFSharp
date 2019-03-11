namespace Iterator

open System

type InOrderIterator<'T>(root: Node<'T>) as x =
    let mutable _current = root
    let mutable _yieldedStart = false
    do
        while not (x.Current.Left |> isNull) do
            x.Current <- x.Current.Left

    member this.Current
        with get(): Node<'T> = _current
        and private set(v): unit = _current <- v

    member this.MoveNext() =
        match this with
        | self when not (_yieldedStart) -> 
                                        _yieldedStart <- true
                                        true
        | self when not (self.Current.Right |> isNull) ->
                                                      self.Current <- self.Current.Right
                                                      while not (self.Current.Left |> isNull) do
                                                         self.Current <- self.Current.Left
                                                      true
        | _ -> 
            let mutable p = this.Current.Parent
            while (not (p |> isNull)) && this.Current = p.Right do
                this.Current <- p
                p <- p.Parent
            this.Current <- p
            not (this.Current |> isNull)
            


    member this.Reset(): unit = 
        this.Current <- root
        _yieldedStart <- false