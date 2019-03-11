module Decorator.Program
open Decorator.StaticDecoratorComposition
open System

//let private sample1 = fun () ->
//    // printfn "%s" (CodeBuilder().ImportantInfo())
//    let hello = "hello"
//    let text = hello + " world"
//    printfn "%s" text
//    
//let private sample2() =
//    let d = Dragon(Bird(), Lizard())
//    d.Weight <- 20
//    (d :> IBird).Fly()
//    (d :> ILizard).Crawl()
//    
//let private sample3() =
//    let square = Square(1.23)
//    printfn "%s" ((square :> IShape).AsString())
//    let redSquare = ColoredShape(square, "Red")
//    Console.WriteLine((redSquare :> IShape).AsString())
//    let halfTransparentSquare = TransparentShape(redSquare, 0.5)
//    printfn "%s" ((halfTransparentSquare :> IShape).AsString())
    
// let private sample4() =
//    let redSquare = ColoredShape<Square>("Red")
//    printfn "%s" (redSquare.AsString())
    // let circle = TransparentShape<ColoredShape<Circle>>(0.4)
    // printfn "%s" (circle.AsString())
    // just dont do this in f#....

[<EntryPoint>]
let main argv =    
    0