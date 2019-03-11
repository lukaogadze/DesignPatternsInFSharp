module LiskovSubstitution.Program

let area (r: Rectangle) = r.Height * r.Width

[<EntryPoint>]
let main argv =
    let rc = Rectangle(2, 3)
    printfn "%A has area %d" rc (area rc)

    let sq: Rectangle = Square() :> Rectangle
    sq.Width <- 4;
    printfn "%A has area %d" sq (area sq)
    0
