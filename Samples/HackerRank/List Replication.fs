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
    
(*
let input = stdin.ReadToEnd().Split '\n' |> Array.map(fun x -> int(x))
let output = Array.foldBack (fun elem acc -> (List.replicate input.[0] elem)@acc) input.[1..] []
List.fold (fun acc x -> printfn "%A" x) () output
*)

(*
let read() = System.Console.ReadLine()

let s = read() |> System.Convert.ToInt32
let rec loop() =
    match read() with
    | null -> ignore()
    | x -> 
        for i in [1..s] do
            printfn "%s" x
        loop()

loop()
*)
