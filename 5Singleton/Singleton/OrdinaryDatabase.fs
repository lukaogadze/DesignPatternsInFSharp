namespace Singleton

open System
open MoreLinq
open System.Linq
open System.IO

type OrdinaryDatabase() =
    let _capitals = File.ReadAllLines("capitals.txt")
                        .Batch(2)
                        .ToDictionary((fun list -> list.ElementAt(0).Trim()),
                                      (fun (list: seq<string>) -> Int32.Parse(list.ElementAt(1))))
    do printfn "Initializing database"                        
    interface IDatabase with
        member this.GetPopulation name =
            _capitals.[name] 

