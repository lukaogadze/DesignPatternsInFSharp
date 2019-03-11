namespace Singleton

type ConfigurableRecordFinder(database: IDatabase) =    
    member this.GetTotalPopulation(names: seq<string>) =        
        seq { for name in names -> database.GetPopulation(name) }
        |> Seq.sum

