let expand_tail_recursive l =
    let rec loop acc = function
        | [] -> List.rev acc                    (* base case *)
        | hd :: tl -> loop (
                                 (hd :: tl)     (* generates list elements of list *)
                                            :: acc ) tl
    loop [] l

let rec expand_not_tail_recursive = function
    | [] -> []
    | hd :: tl -> (hd :: tl) :: expand_not_tail_recursive tl

expand_tail_recursive [1..5] ;;
expand_tail_recursive [ "monkey"; "kitty"; "bunny"; "rat" ];;
