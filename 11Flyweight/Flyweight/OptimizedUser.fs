namespace Flyweight
open System
open System.Collections.Generic
open System.Linq

type OptimizedUser(fullName: string) =
    static let strings = List<string>()
    let mutable names: int[] = [||]
    do
        let getOrAdd s =
            let index = strings.IndexOf(s)
            if not (index.Equals(-1)) then
                index
            else
                strings.Add(s)
                strings.Count - 1
        names <- fullName.Split(' ').Select(getOrAdd).ToArray()
        
    member this.FullName() = String.Join(" ", names.Select(fun i -> strings.[i]))                                              