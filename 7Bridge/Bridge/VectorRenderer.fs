namespace Bridge

type VectorRenderer() =
    interface IRenderer with
        member this.RenderCircle radius =
            printfn "Drawing a circle of radius %s" (radius.ToString())

