namespace Iterator

type BinaryTree<'T>(root: Node<'T>) =
    member this.InOrder
        with get() : seq<Node<'T>> =
            let rec traverse (current: Node<'T>): seq<Node<'T>> =
                let mutable nodes: seq<Node<'T>> = Seq.empty<Node<'T>>
                if not (current.Left |> isNull) then 
                    nodes <- (seq { for left in traverse(current.Left) -> left })
                nodes <- Seq.append nodes (Seq.singleton current)
                if not (current.Right |> isNull) then
                    nodes <- Seq.append nodes (seq { for right in traverse(current.Right) -> right })
                nodes

            seq {for node in traverse(root) -> node}   
    
    member this.GetEnumerator() = InOrderIterator(root)