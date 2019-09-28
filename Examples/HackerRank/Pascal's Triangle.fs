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

(*
open System 

let rec fact = function
    | 0 -> 1
    | n -> n * fact (n - 1)

let nCr n k = (fact n) / (fact k) / (fact (n - k))

let x = Convert.ToInt32(Console.ReadLine())
for n in 0..(x-1) do
    for k in 0..n do
        nCr n k |> printf "%A "
    printf "\n"
*)
