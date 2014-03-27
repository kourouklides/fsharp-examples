let inc a =
    let add =
        (fun x -> (fun y -> x + y))
    if a <= 0 then
        0
    else if a <10 then
        add a 1
    else
    10
    
inc 20

// A List of mutliples of 15
[ for a in 1 .. 100 do
    if a % 3 = 0 && a % 5 = 0 then yield a]
