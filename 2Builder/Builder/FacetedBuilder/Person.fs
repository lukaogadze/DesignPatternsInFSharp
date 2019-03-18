namespace Builder.FacetedBuilder

type Person() =
    member val StreetAdress: string = null with get, set
    member val Postcode: string = null with get, set
    member val City: string = null with get, set
    
    member val CompanyName: string = null with get, set
    member val Position: string = null with get, set
    member val AnnualIncome: int = 0 with get, set
    
    override this.ToString() =
        sprintf "%s: %s, %s: %s, %s: %s, %s: %s, %s: %s, %s: %d"
            "StreetAdress" this.StreetAdress
            "Postcode" this.Postcode
            "City" this.City
            "CompanyName" this.CompanyName
            "Position" this.Position
            "AnnualIncome" this.AnnualIncome