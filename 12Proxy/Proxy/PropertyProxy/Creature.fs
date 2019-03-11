namespace Proxy.PropertyProxy

type Creature() =
    let _agility: Property<int> = Property<int>()
    member this.Agility
        with get(): int = _agility.Value
        and set(v: int) = _agility.Value <- v

