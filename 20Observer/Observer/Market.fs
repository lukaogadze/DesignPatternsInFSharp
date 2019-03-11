namespace Observer

open System.ComponentModel
open System.Runtime.CompilerServices


type Market() =    
    let mutable _volatility = 0.    
//    let mutable _prices = List.empty<float>
    let _propertyChangedEvent = Event<PropertyChangedEventHandler, PropertyChangedEventArgs>()
//    let _priceAddedEvent = Event<float>()    
    
    
//    member this.PriceAdded = _priceAddedEvent.Publish
    member this.Prices = BindingList<float>()
    
    member this.AddPrice price =
//        _prices <- price::_prices
//        _priceAddedEvent.Trigger price
        this.Prices.Add price

    member this.Volatility
        with get() = _volatility
        and set v =
            if v = _volatility then
                ()
            else
                _volatility <- v
                this.OnPropertyChanged();
                
                    

    member private this.OnPropertyChanged([<CallerMemberName>] ?propertyName: string) =
        let prop = defaultArg propertyName "Volatility"
        _propertyChangedEvent.Trigger(this, PropertyChangedEventArgs(prop))

    interface INotifyPropertyChanged with        
        [<CLIEvent>]
        member this.PropertyChanged = _propertyChangedEvent.Publish
