open System

let f n = [1..n]


let main() =
    let input = Console.ReadLine()
    let n = int input
    printfn "%d" (f n).Length

 
main()
