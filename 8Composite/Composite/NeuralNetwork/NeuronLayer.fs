namespace Composite.NeuralNetwork

open System.Collections.ObjectModel

type NeuronLayer() =
    inherit Collection<Neuron>()

