namespace Bridge

type RasterRenderer() =
    interface IRenderer with
        member this.RenderCircle radius =
            printfn "Drawing pixels for circle %s" (radius.ToString())

