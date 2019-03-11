namespace Tests
open Autofac
open NUnit.Framework
open Singleton

[<TestFixture>]
type DIPopulationTest() =
    
    [<Test>]
    member this.``DI Population Test``() =
        let containerBuilder = ContainerBuilder()
        containerBuilder
            .RegisterType<OrdinaryDatabase>()
            .As<IDatabase>()
            .SingleInstance() |> ignore
            
        containerBuilder.RegisterType<ConfigurableRecordFinder>() |> ignore
        use container = containerBuilder.Build()
        let rf = container.Resolve<ConfigurableRecordFinder>()
        ()                                        