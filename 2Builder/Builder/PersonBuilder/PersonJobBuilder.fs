namespace Builder.PersonBuilder

type PersonJobBuilder(person: Person) =    
    member private this.Person = person

    member this.At companyName =
        this.Person.CompanyName <- companyName
        this
    
    member this.As position =
       this.Person.Position <- position
       this

    member this.Earning amount =
        this.Person.AnnualIncome <- amount
        this

    member this.Build() = this.Person    
