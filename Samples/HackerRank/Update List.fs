let f arr = // Complete this function
    arr
   |> List.map (fun x -> abs(x) )

//----------------DON'T MODIFY---------------

let input = 
    stdin.ReadToEnd().Split '\n' 
    |> Array.map(fun x -> int(x)) 
    |> Array.toList
    
let print_out (data:int list) = List.iter (fun x -> printfn "%A" x) data

print_out (f(input))

(*
[<EntryPoint>]
let main args = 
  let inputs = 
    Seq.initInfinite (fun _ -> System.Console.ReadLine())
    |> Seq.takeWhile (fun s -> s <> null)
    |> List.ofSeq
    |> List.map (int >> (fun i -> Operators.abs(i)))
    |> List.iter (printfn "%i")
  0
*)
