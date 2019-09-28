let rec fact x =
    if x < 1 then 1
    else x * fact (x - 1)

//Non tail-recursive INTS
let rec intsN n =
    if n = 0 then []
    else if n > 0 then n::intsN(n-1)
    else []
    
//Tail Recursive INTS
let intsn n =
    let rec intsN x acc =
        if x = 0 then acc
        else intsN (x-1) (x::acc)
    intsN n []
    
//Non tail-recursive SUM
let rec sumN x =
    if x = 0 then 0 else x + sumN(x-1)

//Tail Recursive SUM
let sumn n =
    //Internal definition (local scope)
    let rec sumN x acc=
        if x = 0 then acc 
        else  sumN (x-1) (x+acc)
    // sumn x = sumN n 0
    sumN n 0

// Fibonacci series                     
let rec fib n =                         // let rec fib = function
    match n with                        // | 0 -> 0
    | 0 | 1 -> n                        // | 1 -> 1
    | _ -> fib (n - 1) + fib (n - 2)    // | n -> fib (n - 1) + fib (n - 2)

//Tail-reursive Fibonacci
let fastfib n =
    let rec loop acc1 acc2 = function
        | n when n = 0I -> acc1
        | n -> loop acc2 (acc1 + acc2) (n - 1I)
    loop 0I 1I n

// Fibonacci series using Mutual recursion
let mutrec_fibonacci(x)=
    let rec f(x)= if x=1 then 1 else g(x-1)
    and g(x)= if x=1 then 0 else g(x-1)+f(x-1)
    // mutrec_fibonacci(x)= f(x)+g(x)
    f(x)+g(x)

//Fibonacci series using Anonymous recursion
let fibo = function
    | x when x < 0 -> None
    | x -> let rec fibo2 = function
               | 0 -> 0
               | 1 -> 1
               | x -> fibo2 (x-1) + fibo2 (x-2)
            in Some (fibo2 x)

intsN 5;;
intsn 5;;
fact 5;;
sumN 5;;
sumn 5;;
mutrec_fibonacci(9);;
fibo 9;;
fib 9;;
fastfib 9I;;
