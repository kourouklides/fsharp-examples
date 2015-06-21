open System

// Fibonacci series using Mutual recursion
let mutrec_fibonacci(x)=
    let rec f(x)= if x=1 then -1 else g(x-1)
    and g(x)= if x=1 then 1 else g(x-1)+f(x-1)
    // mutrec_fibonacci(x)= f(x)+g(x)
    f(x)+g(x)


let main() =
    let input = Console.ReadLine() |> int
    let output = mutrec_fibonacci(input)
    printfn "%d" output

 
main()
