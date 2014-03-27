type tree =
    | Leaf of int
    | Node of tree * tree
 
let simpleTree =
    Node(
        Leaf 1,
        Node(
            Leaf 2,
            Node(
                Node(
                    Leaf 4,
                    Leaf 5
                ),
                Leaf 3
            )
        )
    )
    
simpleTree;;
