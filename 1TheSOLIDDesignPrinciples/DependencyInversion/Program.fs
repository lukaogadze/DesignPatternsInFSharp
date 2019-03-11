// Learn more about F# at http://fsharp.org
module DependencyInversion.Program
    
[<EntryPoint>]
let main argv =
    let parent = Person("John")
    let child1 = Person("Chris")
    let child2 = Person("Mary")

    let relationships = RelationShips()
    relationships.AddParentAndChild(parent, child1)
    relationships.AddParentAndChild(parent, child2)
    Research(relationships) |> ignore

    0
