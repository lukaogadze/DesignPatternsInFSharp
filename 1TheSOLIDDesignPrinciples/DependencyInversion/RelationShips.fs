namespace DependencyInversion

open System.Collections.Generic

type RelationShips() = 
    let _relations: List<(Person * Relationship * Person)> = List<(Person * Relationship * Person)>()

    member this.AddParentAndChild(parent: Person, child: Person) =
        _relations.Add (parent, Parent, child)
        _relations.Add (child, Child, parent)
    
    interface IRelationshipBrowser with
        member this.FindAllChildrenOf name =
            let innerFilter = (fun (p: Person * Relationship * Person) -> let person, relationship, _ = p
                                                                          person.Name = name && relationship = Relationship.Parent)
            ((_relations |> Seq.filter innerFilter) |> Seq.map (fun p -> let _, _, per = p
                                                                         per))
            
            
            
                
                    


    //member this.Relations with get() = _relations