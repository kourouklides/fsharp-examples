// Recursive function
let rec fib n =
   if n <= 2 then 1
   else fib (n - 1) + fib (n - 2)
   
// Mutually recursive functions
let rec Even x =
   if x = 0 then true 
   else Odd (x - 1)
and Odd x =
   if x = 1 then true 
   else Even (x - 1)

// Non-recursive functions
let testEven x =
    if Even x then
        printfn "Number %i is even" x

let testOdd x =
    if Odd x then
        printfn "Number %i is odd" x
        
testEven 8
