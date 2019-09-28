open System

let main() =
    
    let input = Console.ReadLine().Split()

    let a = int input.[0]
    let b = int input.[1]

    // Recursively find GCD
    let rec gcd x y =
        if y = 0 then x     // base case
        else gcd y (x % y)  // recursive case

    printfn "%d" (gcd a b)

main()
