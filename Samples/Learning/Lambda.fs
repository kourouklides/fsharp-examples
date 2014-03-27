// Define addition
let add = (fun x y -> x + y)
// evaluate addtion of 2 + 2
add 2 2
// Implement increment using addtion by 1
let inc = add 1

// Second version
let add2 = (fun x -> (fun y -> x + y))
let inc2 = add2 1

// Evaluate sample increments
inc2 8;; inc 10;;

(* let twoTest test =
    test 2

twoTest (fun x -> x < 0)
*)
