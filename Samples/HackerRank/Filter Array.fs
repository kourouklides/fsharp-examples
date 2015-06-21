open System

(*USER CODE BEGIN*)
let f n arr =
    arr
    |> List.filter (fun x -> x < n)
(*USER CODE END*)

let read_and_parse()=
    let mutable arr = []
    let mutable buff = Console.ReadLine()
    while buff <> null do
            arr <- Int32.Parse(buff)::arr
            buff <- Console.ReadLine()
    arr

let main =    
    let arr = read_and_parse() // in a reverse order!
    let h = arr |>List.rev |> List.head
    let t = arr |>List.rev|> List.tail
    f h t |> List.iter (printf "%d \n")
    
