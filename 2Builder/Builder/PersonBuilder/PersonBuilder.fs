namespace Builder.PersonBuilder


type PersonBuilder(person: Person) =
    member private this.Person = person
    member this.Lives = PersonAddressBuilder(this.Person)