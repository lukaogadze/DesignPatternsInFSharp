module Iterator.Program

open System
//      1
//    /   \
//   2     3

// in-order: 213
let private sample1() =
    let root = Node<int>(1, Node<int>(2), Node<int>(3))
    let it = InOrderIterator<int>(root)
    while (it.MoveNext()) do
        printf "%d," (it.Current.Value)
    printfn ""    

let private sample2() =
    let root = Node<int>(1, Node<int>(2), Node<int>(3))
    let tree = BinaryTree<int>(root)
    let data = (tree.InOrder |> Seq.map (fun x -> x.Value))
    printfn "%s" (String.Join(",", data))
    //for node in tree do
    //    printfn "%d" node.Value

[<EntryPoint>]
let main argv =
    sample1();
    sample2()
    0