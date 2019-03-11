namespace Flyweight

open JetBrains.dotMemoryUnit
open System
open Flyweight.TextFormatter
open System.Linq
open System.Collections.Generic
open NUnit.Framework


[<TestFixture>]
type PerformanceTests () =
    
    member this.RandomString(): string =
        let rand = Random()
        let data = Enumerable.Range(0,10).Select(fun i -> char('a' + char(rand.Next(26)))).ToArray()
        String(data)
        
    member this.ForceGC() =
        GC.Collect()
        GC.WaitForPendingFinalizers()
        GC.Collect()
    
    [<Test>]
    member this.TestUser() = 
        let firstNames = Enumerable.Range(0, 100).Select(fun _ -> this.RandomString())
        let lastNames = Enumerable.Range(0, 100).Select(fun _ -> this.RandomString())
        
        let users = List<User>()
        for firstName in firstNames do
            for lastName in lastNames do
                users.Add(User(sprintf "%s %s" firstName lastName))
        
        this.ForceGC()
        
        dotMemory.Check(fun memory -> printfn "%d" memory.SizeInBytes) |> ignore
        ()
        
    [<Test>]
    member this.TestOptimizedUser() =
        let firstNames = Enumerable.Range(0, 100).Select(fun _ -> this.RandomString())
        let lastNames = Enumerable.Range(0, 100).Select(fun _ -> this.RandomString())
        
        let users = List<OptimizedUser>()
        for firstName in firstNames do
            for lastName in lastNames do
                users.Add(OptimizedUser(sprintf "%s %s" firstName lastName))
        
        this.ForceGC()
        
        dotMemory.Check(fun memory -> printfn "%d" memory.SizeInBytes) |> ignore
        ()

    [<Test>]
    member this.TestFormatedText() =
        let formatter = FormattedText("This is a brawe new world");
        formatter.Capitalize(10, 15)
        printfn "%A" formatter
        ()
        
    [<Test>]
    member this.TestBetterFormatedText() =
        let formatter = BetterFormattedText("This is a brawe new world");
        formatter.GetRange(10, 15).WithCapitalize(true) |> ignore
        
        printfn "%A" formatter
        ()        




























                                    