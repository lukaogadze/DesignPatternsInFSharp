namespace Singleton

open System
open System.IO
open MoreLinq
open System.Linq

type SingletonDatabase private() =
    let _capitals = File.ReadAllLines("capitals.txt")
                        .Batch(2)
                        .ToDictionary((fun list -> list.ElementAt(0).Trim()),
                                      (fun (list: seq<string>) -> Int32.Parse(list.ElementAt(1))))
    static let _instance = lazy (SingletonDatabase() :> IDatabase)
    static let mutable _instanceCount = 0    
    do
        printfn "Initializing database"
        _instanceCount <- 1 + _instanceCount
    static member Instance = _instance.Force()
    static member Count = _instanceCount
    
    interface IDatabase with
        member this.GetPopulation name =
            _capitals.[name]

   