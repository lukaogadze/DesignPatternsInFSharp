namespace Builder.FacetedBuilder

type PersonBuilder() =
    let mutable _person = Person()
    member internal this.Person
        with get() = _person
        and set v = _person <- v
        
    member this.Works = PersonJobBuilder(this.Person)
    member this.Lives = PersonAddressBuilder(this.Person)
    member this.Build() = this.Person
    
and PersonJobBuilder(person: Person) as x =
    inherit PersonBuilder()
    do x.Person <- person
    
    member this.At companyName : PersonJobBuilder =
        this.Person.CompanyName <- companyName
        this
    
    member this.AsA position : PersonJobBuilder =
        this.Person.Position <- position
        this
    
    member this.Earning amount : PersonJobBuilder =
        this.Person.AnnualIncome <- amount
        this
        
and PersonAddressBuilder(person: Person) as z =
    inherit PersonBuilder()
    do z.Person <- person
    
    member this.At streetAddress : PersonAddressBuilder =
        this.Person.StreetAdress <- streetAddress
        this
        
    member this.WithPostcode postCode : PersonAddressBuilder =
        this.Person.Postcode <- postCode
        this
        
    member this.In city : PersonAddressBuilder =
        this.Person.City <- city
        this