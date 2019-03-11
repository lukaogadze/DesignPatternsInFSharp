module Bridge.Program
open Autofac

[<EntryPoint>]
let main(argv: string[]): int =
    let containerBuilder = ContainerBuilder()
    containerBuilder.RegisterType<VectorRenderer>().As<IRenderer>().SingleInstance() |> ignore
    containerBuilder.Register(fun c p -> Circle(c.Resolve<IRenderer>(), p.Positional<float>(0))) |> ignore
    use container = containerBuilder.Build()
    let circle = container.Resolve<Circle>(new PositionalParameter(0,5.))
    circle.Draw()
    circle.Resize(2.)
    circle.Draw()
    0
