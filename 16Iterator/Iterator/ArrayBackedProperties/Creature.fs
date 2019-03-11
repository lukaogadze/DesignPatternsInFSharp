namespace Iterator.ArrayBackedProperties

open System.Collections.Generic
open System.Collections
open System.Linq

type Creature(strenght: int, agility: int, intelligence: int) =
    let _stats = [|strenght; agility; intelligence|]

    member this.Strength
        with get() = _stats.[0]
        and set(v) = _stats.[0] <- v
    member this.Agility
        with get() = _stats.[1]
        and set(v) = _stats.[1] <- v
    member this.Intelligence
        with get() = _stats.[2]
        and set(v) = _stats.[2] <- v

    member this.AverageStat = Array.average (_stats |> Array.map (fun x -> float x))

    member this.Item
        with get i = _stats.[i]
        and set i v = _stats.[i] <- v

    interface IEnumerable<int> with
        member this.GetEnumerator(): IEnumerator<int> =
            _stats.AsEnumerable().GetEnumerator()

        member this.GetEnumerator() =
            (this :> IEnumerable<int>).GetEnumerator() :> IEnumerator
