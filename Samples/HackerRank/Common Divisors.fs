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
