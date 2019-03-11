namespace Singleton

type SingletonRecordFinder() =
    member this.GetTotalPopulation(names: seq<string>) =
        let db = SingletonDatabase.Instance
        seq { for name in names -> db.GetPopulation(name) }
        |> Seq.sum