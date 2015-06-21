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

//    let s = Seq.nth 0 inputList
    let s = inputList |> Seq.head
    let L = inputList |> Seq.length

    for i = 1 to L-1 do
        for j = 1 to s do
            let x = Seq.nth i inputList 
            printf "%d \n" x
    
    0 // return an integer exit code
    
