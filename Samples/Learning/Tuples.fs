let average (a, b) =
    (a + b) / 2.0
    
let swap (a, b) = (b, a)

let divrem x y =
    match y with
    | 0 -> None
    | _ -> Some(x / y, x % y);;

let getLocation = function
    | (0, 0) -> "origin"
    | (0, y) -> "on the y-axis at y = " + y.ToString()
    | (x, 0) -> "on the x-axis at x = " + x.ToString()
    | (x, y) -> "at x = " + x.ToString() + ", y = " + y.ToString() 

average (10.0, 20.0);;
swap ("Web", 2.0);;
swap (20, 30);;
divrem 6 4;;
divrem 7 0;;
let x, y, z = (1, 0, 2);;
getLocation (x,y);;
//System.Math.DivRem(10, 7);;   //Works only in VS
