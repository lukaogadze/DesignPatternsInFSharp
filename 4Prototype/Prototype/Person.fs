module Prototype.Program

type Person(names: string[], address: Address) =
    new () = Person(Array.empty<string>, Address())
    member val Names = names with get, set
    member val Address = address with get, set

    override this.ToString() =
        sprintf "%s: %s, Address: {%A}" "Names" (System.String.Join(" ", this.Names)) this.Address


