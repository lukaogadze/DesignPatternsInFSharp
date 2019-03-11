namespace Builder.PersonBuilder


type PersonAddressBuilder(person: Person) =
    member private this.Person = person
    member this.Works = PersonJobBuilder(this.Person)

    member this.At streetAddress =
        this.Person.StreetAddress <- streetAddress
        this

    member this.WithPostCode postCode =
       this.Person.PostCode <- postCode
       this

    member this.In city =
        this.Person.City <- city
        this