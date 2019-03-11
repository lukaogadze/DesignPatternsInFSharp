namespace ChainOfResponsibility

type Creature(name: string, attack: int, defence: int) =
    member val Name = name with get, set
    member val Attack = attack with get, set
    member val Defence = defence with get, set

    override this.ToString() =
        sprintf "%s: %s, %s: %d, %s: %d" "Name" this.Name "Attack" this.Attack "Defence" this.Defence

