module Observer.Program

open System
open Observer.WeakEvent
open System.ComponentModel


let private sample1() =
    let callDoctor _ (args: FallsIllEventArgs) =
        printfn "A doctor has been called to %s" args.Address

    let person = Person()
    let handler = Handler<FallsIllEventArgs>(callDoctor)
    person.FallsIll.AddHandler(handler)
    person.CatchACold()
    person.FallsIll.RemoveHandler(handler)
    person.CatchACold()

let private sample2() =
    let button = Button()
    let mutable window = new Window(button)
    let windowRef = WeakReference(window)
    
    button.Fire()

    (window :> IDisposable).Dispose()
    // window <- null
    printfn "Finalizing window/Disposing"
    
    GC.Collect()
    GC.WaitForPendingFinalizers()
    GC.Collect()
    printfn "Window is still alive? %b" windowRef.IsAlive
    button.Fire()
    // hmm... use IDisposable to free up memory

let private sample3() =
    let market = Market() :> INotifyPropertyChanged
    let notifyOnChanged sender (args: PropertyChangedEventArgs) =
        if args.PropertyName = "Volatility" then
            printfn "Volatility changed"
        
    let handler = PropertyChangedEventHandler(notifyOnChanged)
    
    market.PropertyChanged.AddHandler(handler)
    (market :?> Market).Volatility <- 25.
    market.PropertyChanged.RemoveHandler(handler)
    (market :?> Market).Volatility <- 25.4


//let private sample4() =
//    let market = Market()
//    using(market.PriceAdded.Subscribe(fun p -> printfn "We got a price of %.1f" p))(fun _ ->
//        market.AddPrice(123.)
//    )

let private sample5() =
    let market = Market()
    market.Prices.ListChanged.Subscribe(fun args ->
        printfn "Binding list got a price of %.1f" (market.Prices.[args.NewIndex])
    ) |> ignore
    ( fun _ -> market.AddPrice 126.)()
    // this doesn't works in f#.... wtf
    


[<EntryPoint>]
let main argv =
    // sample1();
    // sample2()
    // sample3()
    // sample4()
    // sample5()
    0


































