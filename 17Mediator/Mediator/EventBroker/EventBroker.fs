namespace Mediator.EventBroker

open System
open System.Reactive.Subjects

type EventBroker() =
    let _subscriptions = new Subject<PlayerEvent>()

    interface IObservable<PlayerEvent> with
        member this.Subscribe(observer: IObserver<PlayerEvent>): IDisposable =
            _subscriptions.Subscribe(observer)            
    

    member this.Publish(playerEvent: PlayerEvent): unit =
        _subscriptions.OnNext(playerEvent)