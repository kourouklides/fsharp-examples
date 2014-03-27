let pair l =
    let rec loop acc = function
        | [] | [_] -> List.rev acc              (* base case *)
        | h1 :: h2 :: tl -> loop (
                                    (h1, h2)    (* generates pair elements of list *)
                                             :: acc) tl
    loop [] l
 
let unpair l =
    let rec loop acc = function
        | [] -> List.rev acc
        | (h1, h2) :: tl -> loop (h2 :: h1 :: acc) tl
    loop [] l

// Alternative implementations of unpair:
let unpair2 l = List.foldBack (fun (x,y) s -> x::y::s) l [];;

pair [ 1 .. 10 ];;
pair [ "one"; "two"; "three"; "four"; "five" ];;
unpair [(1, 2); (3, 4); (5, 6)];;
unpair (pair [ 1 .. 11 ]);;
pair (unpair [(1, 2); (3, 4); (5, 6)]);;
