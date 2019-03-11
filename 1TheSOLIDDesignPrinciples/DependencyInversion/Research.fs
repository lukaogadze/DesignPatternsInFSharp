namespace DependencyInversion

//type Research(relationships: RelationShips) = 
    //do
    //    for r in (relationships.Relations |> Seq.filter (fun p -> let person, relationship, _ = p
    //                                                              person.Name = "John" && relationship = Relationship.Parent)) do
    //        printfn "John has a child called %s" ((fun s -> let _, _, child = r
    //                                                        child.Name) r)

type Research(browser: IRelationshipBrowser) =
    do
        for p in browser.FindAllChildrenOf "John" do
            printfn "John has a child called %s" p.Name