namespace Tests
open NUnit.Framework
open Singleton


[<TestFixture>]
type SingletonRecordFinderShould() =
    
    [<Test>]
    member this.``get total population from cities`` ()=
        let rf = SingletonRecordFinder()
        let names = ["Seoul"; "Mexico City"]
        let totalPopulation = rf.GetTotalPopulation names
        Assert.That(totalPopulation, Is.EqualTo(17500000 + 17400000))        