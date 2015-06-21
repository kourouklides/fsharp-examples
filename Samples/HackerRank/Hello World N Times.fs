open System

[<EntryPoint>]
let main argv = 
    let n = Console.ReadLine() |> int

    let msg = "Hello World"

    for i = 1 to n do
      printfn "%s" msg

    0 // return an integer exit code
    
