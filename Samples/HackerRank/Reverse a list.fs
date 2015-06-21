open System

[<EntryPoint>]
let main argv = 

    let read _ = Console.ReadLine()
    let isValid = function null -> false | _ -> true
    let inputList =
        Seq.initInfinite read
        |> Seq.takeWhile isValid
        |> Seq.toList
        |> Seq.map int
     

    let reverse = inputList |> Seq.toArray |> Array.rev  |> Array.iter (printf "%d \n")

    0 // return an integer exit code
