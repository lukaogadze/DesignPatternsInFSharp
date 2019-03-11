namespace Decorator.MultipleInheritance

type Lizard() =    
    interface ILizard with
        member val Weight = 0 with get, set        
        member this.Crawl() = printfn "Crawling in the dirt with weight %d" ((this :> ILizard).Weight)        
        
        

