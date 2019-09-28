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
    
    let L = inputList |> Seq.length
    
    printfn "%d" L
    
    0 // return an integer exit code

(*
open System

let countAll input = 
     List.fold (fun acc x -> acc + 1) 0 input

// Boiler plate stuff for HackerRank
[<EntryPoint>]
let main argv = 
    
    let readInputsAsInts = 
      Seq.initInfinite (fun _ -> System.Console.ReadLine())
      |> Seq.takeWhile (fun s -> s <> null)
      |> Seq.map(fun c -> int c)
      |> Seq.toList
    
    Console.Write (countAll readInputsAsInts)
    0
*)
