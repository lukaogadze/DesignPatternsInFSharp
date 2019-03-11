namespace Builder.PersonBuilder

type Person() =
    member val StreetAddress = "" with get, set
    member val PostCode = "" with get, set
    member val City = "" with get, set
    member val CompanyName = "" with get, set
    member val Position = "" with get, set
    member val AnnualIncome = 0 with get, set

    override this.ToString() =
        sprintf "%s: %s, %s: %s, %s: %s, %s: %s, %s: %s, %s: %d" 
            "StreetAddress" this.StreetAddress 
            "PostCode" this.PostCode 
            "City" this.City 
            "CompanyName" this.CompanyName
            "Position" this.Position
            "AnnualIncome" this.AnnualIncome

