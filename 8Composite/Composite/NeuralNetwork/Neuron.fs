namespace Composite.NeuralNetwork

open System.Collections
open System.Collections.Generic


type Neuron() =
    let _value = 0.
    member this.In = List<Neuron>()
    member this.Out = List<Neuron>()

    interface IEnumerable<Neuron> with                     
        member this.GetEnumerator(): IEnumerator<Neuron> =
            (Seq.singleton this).GetEnumerator()
    
        member this.GetEnumerator(): IEnumerator =
            (this :> IEnumerable<Neuron>).GetEnumerator() :> IEnumerator 