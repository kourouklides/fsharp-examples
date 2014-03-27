let newtonSqrt x : float =
    let rec findSqrt a : float =
        // less than ε=0.00001
        if abs (x - a * a) < 0.00001 then a
        else findSqrt ((a + x/a) / 2.0)
    findSqrt (x/2.0)

(*let newtonsqrt x  =
    let findSqrt (a : float,list) =
        // less than ε=0.00001
        if abs (x - a * a) < 0.00001 then list
        //else findSqrt ((a + x/a) / 2.0)
    findSqrt ((x/2.0), [])
        
newtonSqrt 12.0;; 
newtonsqrt 12.0  *)
let swap (a : float, b) =
    if a> 3.0 then (b, a)
    else (a,b)
    
swap (5.0, 3::2::[]);;

