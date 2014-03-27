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
    if y = 0 then x
    else gcd y (x % y)  //
 
Console.WriteLine(gcd a b) // print gcd(a,b)
