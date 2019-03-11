namespace Mediator.EventBroker

type Actor(broker: EventBroker) = 
    member internal this.Broker = broker