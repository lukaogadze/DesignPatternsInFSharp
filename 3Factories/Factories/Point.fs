namespace Factories

open System


type Point private (x: double, y: double) =
    static member NewCartesianPoint(x, y) = Point(x, y)
    static member NewPolarPoint(rho: double, theta: double) = Point(rho * Math.Cos(theta), rho * Math.Sin(theta))    
    static member Origin = Point(0.,0.)
    override this.ToString() = 
        sprintf "%s: %A, %s: %A" "X" x "Y" y
    