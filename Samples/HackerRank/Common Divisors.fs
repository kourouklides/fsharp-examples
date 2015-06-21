open System

let main() =
    // Recursively find GCD
    let rec gcd a b =
        if a = b then a
        elif a > b then gcd (a-b) b
        else gcd a (b-a)

    // Factors/Divisors of a number (greater than 1)
    let factors number = seq {
        for divisor in 1 .. (float >> sqrt >> int) number do
        if number % divisor = 0 then
            yield divisor
            yield number / divisor
    }

    // Number of factors of a single number
    let noFactors x =
        if x <> 1 then
            let d = factors x
            let d_unique = Seq.distinct d // account for perfect squares
            Seq.length d_unique
        else
            1

    // Number of common divisors of two number
    let divisors a b =
        let num = gcd a b
        noFactors num

    let T = Console.ReadLine() |> int

    let output = Array.create T 0
    // let output = Array.init T (fun x -> x)

    for i = 0 to T-1 do
        let input = Console.ReadLine().Split()

        let M = int input.[0]
        let L = int input.[1]

        let d = divisors M L

        Array.set output i d
    
    output |> Array.iter (printf "%d \n")

main()

(*
let rec gcd (a, b) =
    match b with
        | 0 -> a
        | _ -> gcd (b, a % b)


let div_count n =
    let rec divs acc = function
            | []        -> acc
            | h :: t    -> if n % h = 0 then if n / h = h then divs (acc + 1) t
                                                          else divs (acc + 2) t
                                        else divs acc t
    
    let sqrt_n = n |> float |> sqrt |> int
    divs 0 [1..sqrt_n]


let T = System.Console.ReadLine() |> int
for i in 1..T do
    let (L, M) = System.Console.ReadLine().Split(' ') |> Array.map (int) |> (fun arr -> arr.[0], arr.[1])
    gcd (L, M) |> div_count |> System.Console.WriteLine
*)
