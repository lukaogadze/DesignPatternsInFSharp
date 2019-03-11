namespace Builder

type HtmlBuilder(rootName: string) =
    let mutable _root = HtmlElement(rootName, "");

    member this.AddChild htmlElement =
        _root.Elements <- _root.Elements @ [htmlElement]
        this

    member this.Clear() =
        _root <- HtmlElement(rootName, "")

    override this.ToString() = _root.ToString()

