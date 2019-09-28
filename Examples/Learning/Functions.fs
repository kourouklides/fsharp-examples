let quadruple x =    
    // define double
    let double x =
        x * 2
    // define quadraple
    double(double(x))

let chrisTest test =
    test "Chris"

let isMe x =
    if x = "Chris" then
        "it is Chris!"
    else
        "it's someone else"

let sumOfDivisors n =
    let rec loop current max acc =
        if current > max then
            acc
        else
            if n % current = 0 then
                loop (current + 1) max (acc + current)
            else
                loop (current + 1) max acc
    let start = 2
    let max = n / 2     (* largest factor, apart from n, cannot be > n / 2 *)
    let minSum = 1 + n  (* 1 and n are already factors of n, assuming n!=1 *)
    loop start max minSum
      
;;
quadruple 2;;
chrisTest isMe;;
sumOfDivisors 2;;
