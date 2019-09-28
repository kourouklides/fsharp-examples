open System

[<EntryPoint>]
let main argv = 
    let read _ = Console.ReadLine()
    let isValid = function null -> false | _ -> true
    let inputList =
        Seq.initInfinite read
        |> Seq.takeWhile isValid
        |> Seq.map int
        |> Seq.mapi (fun i el -> el, i)
        |> Seq.filter (fun (el, i) -> i % 2 <> 0)
        |> Seq.map fst
        |> Seq.iter (printfn "%i")
    
    0 // return an integer exit code
    
