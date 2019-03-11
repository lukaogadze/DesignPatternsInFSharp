namespace Tests
open NUnit.Framework
open Singleton


[<TestFixture>]
type ConfigurableRecordFinderShould() =
    
    [<Test>]
    member this.``get total population from cities``() =
        let rf = ConfigurableRecordFinder(DummyDatabase())
        let names = ["alpha";"gamma"];
        let totalPopulation = rf.GetTotalPopulation names
        Assert.AreEqual(4, totalPopulation)
        ()
    

