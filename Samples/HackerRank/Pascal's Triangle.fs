open System

// Factorial
let rec fact x =
    if x < 1 then 1
    else x * fact (x - 1)

let pascal k =
    for n = 0 to k-1 do
        for r = 0 to n do
            printf "%d " (fact(n)/(fact(r)*fact(n-r)))
        Console.WriteLine()

let main() =
    let k = Console.ReadLine() |> int
    pascal k
 
main()
