namespace Tests

open NUnit.Framework
open Singleton

[<TestFixture>]
type SingletonShould () =

    [<Test>]
    member this.``Have a Fild Instance Implemented as Singleton `` () =
        let db = SingletonDatabase.Instance
        let db2 = SingletonDatabase.Instance
        Assert.That(db, Is.SameAs db2)
        Assert.That(SingletonDatabase.Count, Is.EqualTo 1)

