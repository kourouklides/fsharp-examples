// Find GCD (Greater Common Divisor)
// Language: F#

open System
 
// Read one of the numbers as string and parse to integer
let a =
    Console.ReadLine() |> System.Int32.Parse
    
// Read the other integer
let b =
    Console.ReadLine() |> System.Int32.Parse

// Recursively find GCD
let rec gcd x y =
    if y = 0 then x     // base case
    else gcd y (x % y)  // recursive case

// Print GCD(a,b)
Console.WriteLine(gcd a b) 
