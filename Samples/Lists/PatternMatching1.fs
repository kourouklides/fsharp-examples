// Pattern Matching Lists

let sum numbers =                   (* numbers is the input parameter*)
    let rec sum total = function    (* total is an accumulating parameter *)
        | [] -> total               (* base case *)
        | hd :: tl -> sum
                            (hd + total)
                                         tl
    sum 0 numbers                   (* total initialised to 0 *)

// Reverse a list (instead of using built-in function List.rev)
let reverse l =                     (* l is the input parameter*)
    let rec loop acc = function     (* acc is an accumulating parameter *)
        | [] -> acc                 (* base case *)
        | hd :: tl -> loop 
                            (hd :: acc)
                                         tl
    loop [] l                       (* acc initialised to [] *)

sum [ 1 .. 5 ];;

reverse [ 1 .. 5 ];;
