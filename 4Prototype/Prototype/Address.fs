namespace Prototype

type Address(streetName: string, houseNumber: int) =
    new () = Address("",0)
    member val StreetName = streetName with get, set
    member val HouseNumber = houseNumber with get, set

    override this.ToString() =
        sprintf "%s: %s, %s: %d" "StreetName" this.StreetName "HouseNumber" this.HouseNumber