namespace Singleton
open System.Collections.Generic

type DummyDatabase() =
    interface IDatabase with
        member this.GetPopulation name =
            let data = Dictionary<string, int>()
            data.Add("alpha",1)
            data.Add("beta", 2)
            data.Add("gamma", 3)
            data.[name]

