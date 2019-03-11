namespace OpenClosed.Products

open System

type Product(name: string, color: Color, size: Size) =
    do if name = null then raise(ArgumentNullException(paramName = "name"))
    member this.Name = name
    member this.Color = color
    member this.Size = size

    override this.ToString(): string =
        sprintf "Name: %s, Color: %s, Size: %s" this.Name (this.Color.ToString())  (this.Size.ToString())

