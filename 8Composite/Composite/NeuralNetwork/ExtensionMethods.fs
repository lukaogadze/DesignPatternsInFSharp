namespace Composite.NeuralNetwork

open System.Runtime.CompilerServices
open System.Collections.Generic

[<Extension>]
type ExtensionMethods() =

    [<Extension>]
    static member inline ConnectTo(self: IEnumerable<Neuron>, other: IEnumerable<Neuron>) =
        if obj.ReferenceEquals(self, other)
            then ()
        else
            for from in self do
                for aTo in other do
                    from.Out.Add aTo
                    aTo.In.Add from