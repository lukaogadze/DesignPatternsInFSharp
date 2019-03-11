module Composite.Program

open Composite.NeuralNetwork

let private graphicsObjectExample() =
    let drawing = GraphicObject(Name = "My Drawing")
    drawing.Children.Add(Square(Color = "Red"))
    drawing.Children.Add(Circle(Color = "Yellow"))

    let group = new GraphicObject()
    group.Children.Add(Circle(Color = "Blue"))
    group.Children.Add(Square(Color = "Blue"))
    drawing.Children.Add(group)
    printfn "%A" drawing

let private neuralNetworkExample() =
    let neuron1 = Neuron()
    let neuron2 = Neuron()
    
    neuron1.ConnectTo(neuron2)

    let layer1 = NeuronLayer()
    let layer2 = NeuronLayer()
    neuron1.ConnectTo(neuron2)
    layer1.ConnectTo(layer2)
    ()

[<EntryPoint>]
let main argv =    
    neuralNetworkExample()
    0
