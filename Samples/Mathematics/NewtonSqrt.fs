let newtonSqrt (x : float) (accuracy : float) =
    if x < 0.0 then
        failwith "Negative argument to newtonSqrt"
    let rec findSqrt a =
        if abs (x - a*a) < accuracy then
            a
        else
            findSqrt ( (a + x/a) / 2.0 )
    findSqrt (x / 2.0)

// Evaluate Sqrt of 2.0 using accuracy ε=0.00001
printfn "sqrt(2.0) = %A" (newtonSqrt 2.0 0.00001)
